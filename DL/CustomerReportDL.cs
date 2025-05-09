using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class CustomerReportDL
    {
        public static List<CustomerReportBL> GetCustomers()
        {
            string qry = "SELECT customers.fullname AS Name,customers.phone AS Phone_number,customers.address AS Address,COUNT(bills.bill_id) AS Total_Bills,COALESCE(SUM(bills.totalamount), 0) AS Total_Purchase FROM customers LEFT JOIN bills ON customers.customer_id = bills.customer_id AND bills.deleted = 0 GROUP BY customers.customer_id;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<CustomerReportBL> customers = new List<CustomerReportBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string name = (dr["Name"]).ToString();
                string phone = (dr["Phone_number"]).ToString();
                string address = (dr["Address"]).ToString();
                int total_bills = Convert.ToInt32(dr["Total_Bills"]);
                double total_amount = Convert.ToDouble(dr["Total_Purchase"]);
                CustomerReportBL c = new CustomerReportBL(name, phone, address, total_bills, total_amount);
                customers.Add(c);
            }
            return customers;
        }
    }
}
