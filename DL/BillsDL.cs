using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.BL;
using HyperstarManagementSystem.DL;
using HyperstarManagementSystem.UI;
using MySql.Data.MySqlClient;


namespace HyperstarManagementSystem
{
    internal class BillsDL
    {
        public static List<BillsBL> GetAll()
        {
            string qry = "select * from bills where deleted = 0";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<BillsBL> bills = new List<BillsBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int billID = Convert.ToInt32(dr["bill_id"]);
                int customerID = Convert.ToInt32(dr["customer_id"]);
                //int employeeID = Convert.ToInt32(dr["employeeID"]);
                string billDate = dr["billdate"].ToString();
                decimal totalAmount = Convert.ToDecimal(dr["totalamount"]);
                List<BillDetailBL> billDetails = BillDetailDL.GetBilldetailsByBillID(billID);
                PaymentBL payment = PaymentDL.getPaymentByBill(billID);
                BillsBL b = new BillsBL(billID, customerID, 1, billDate, totalAmount, billDetails,payment);
                bills.Add(b);
            }
            return bills;
        }
        public static bool SaveBillTransaction(BillsBL bill)
        {
            string connStr = "server=localhost;user=root;database=hyperstarfinal;password=nehanking;";

            using (var conn = new MySqlConnection(connStr))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // 1. Insert bill with 0 totalamount
                        var billCmd = new MySqlCommand("INSERT INTO bills (customer_id, totalamount, billdate, employee_id) VALUES (@cid, 0, @bdate, @eid)", conn, transaction);
                        billCmd.Parameters.AddWithValue("@cid", bill.CustomerID);
                        billCmd.Parameters.AddWithValue("@eid", bill.EmployeeID);
                        billCmd.Parameters.AddWithValue("@bdate", bill.BillDate);
                        billCmd.ExecuteNonQuery();

                        long billId = billCmd.LastInsertedId;

                        // 2. Insert bill details
                        foreach (var detail in bill.BillDetails)
                        {
                            var detailCmd = new MySqlCommand(@"INSERT INTO billdetails (bill_id, product_code, qty) VALUES (@bid, @pcode, @qty)", conn, transaction);
                            detailCmd.Parameters.AddWithValue("@bid", billId);
                            detailCmd.Parameters.AddWithValue("@pcode", detail.ProductCode);
                            detailCmd.Parameters.AddWithValue("@qty", detail.Quantity);
                            detailCmd.ExecuteNonQuery();

                            // 3. Update stock
                            var stockCmd = new MySqlCommand("UPDATE products SET in_stock = in_stock - @qty WHERE product_code = @pcode", conn, transaction);
                            stockCmd.Parameters.AddWithValue("@qty", detail.Quantity);
                            stockCmd.Parameters.AddWithValue("@pcode", detail.ProductCode);
                            stockCmd.ExecuteNonQuery();

                        }

                        // 4. Get totalamount from trigger-generated billdetails
                        var totalCmd = new MySqlCommand("SELECT SUM(total_price) FROM billdetails WHERE bill_id = @bid", conn, transaction);
                        totalCmd.Parameters.AddWithValue("@bid", billId);
                        decimal totalAmount = Convert.ToDecimal(totalCmd.ExecuteScalar());

                        // 5. Update the bill with correct total
                        var updateBill = new MySqlCommand("UPDATE bills SET totalamount = @total WHERE bill_id = @bid", conn, transaction);
                        updateBill.Parameters.AddWithValue("@total", totalAmount);
                        updateBill.Parameters.AddWithValue("@bid", billId);
                        updateBill.ExecuteNonQuery();

                        // 6. Insert payment
                        var payCmd = new MySqlCommand("INSERT INTO payments (bill_id, cash_rec) VALUES (@bid, @cash)", conn, transaction);
                        payCmd.Parameters.AddWithValue("@bid", billId);
                        payCmd.Parameters.AddWithValue("@cash", bill.Payment.CashReceived);
                        payCmd.ExecuteNonQuery();

                        transaction.Commit();
                        return true;
                    }
                    catch
                    {
                        transaction.Rollback();
                        return false;
                    }
                }
            }
        }

    }
}
