using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class CustomerDL
    {
        public static List<CustomerBL> GetCustomer()
        {
            DataTable dt = new DataTable();
            string qry = "select * from customers";
            dt = DataBaseHelper.GetTable(qry);
            List<CustomerBL> customers = new List<CustomerBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int id = Convert.ToInt32(dr["customer_id"]);
                string name = dr["fullname"].ToString();
                string phone = dr["phone"].ToString();
                string address = dr["address"].ToString();
                CustomerBL c = new CustomerBL(id, name, phone, address);
                customers.Add(c);
            }
            return customers;
        }
        public static List<CustomerBL> SearchCustomer(string name)
        {
            DataTable dt = new DataTable();
            string qry = $"select * from customers where fullname like '{name}%'";
            dt = DataBaseHelper.GetTable(qry);
            List<CustomerBL> customers = new List<CustomerBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int customerId = Convert.ToInt32(dr["customer_id"]);
                string name1 = dr["fullname"].ToString();
                string phone = dr["phone"].ToString();
                string address = dr["address"].ToString();
                CustomerBL c = new CustomerBL(customerId, name1, phone, address);
                customers.Add(c);
            }
            return customers;
        }
        public static void AddCustomer(CustomerBL customer)
        {
            string qry = $"insert into customers (fullname, phone, address) values ('{customer.Name}', '{customer.Phone}', '{customer.Address}')";
            DataBaseHelper.ExecuteDML(qry);
        }
        public static void UpdateCustomer(CustomerBL customer)
        {
            string qry = $"update customers set fullname = '{customer.Name}', phone = '{customer.Phone}', address = '{customer.Address}' where customer_id = {customer.Id}";
            DataBaseHelper.ExecuteDML(qry);
        }
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
