using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.DL
{
    internal class CustomerDL
    {
        public static int getCustomerIdByPhone(string phoneNumber)
        {
            string qry = $"select customer_id from customers where phone = '{phoneNumber}'";
            DataTable dt = DataBaseHelper.GetTable(qry);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0][0]);
            }
            else
            {
                return -1; // or throw an exception if preferred
            }
        }
    }
}
