using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;
using HyperstarManagementSystem.DL;


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
                BillsBL b = new BillsBL(billID, customerID, 1, billDate, totalAmount, billDetails);
                bills.Add(b);
            }
            return bills;
        }
    }
}
