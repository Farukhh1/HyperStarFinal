using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HyperstarManagementSystem.BL;
using System.ComponentModel;
using System.Drawing;

namespace HyperstarManagementSystem.DL
{
    internal class StockOrderDL
    {
        public static List<StockOrderBL> GetAll()
        {
            string qry = "select * from stockorders";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<StockOrderBL> stockOrders = new List<StockOrderBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int order_id = Convert.ToInt32(dr["order_id"]);
                int employee_id = Convert.ToInt32(dr["emp_id"]);
                string product_code = dr["product_code"].ToString();
                string order_date = dr["order_date"].ToString();
                string action = dr["action"].ToString();
                StockOrderBL s = new StockOrderBL(order_id, employee_id, product_code, order_date, action);
                stockOrders.Add(s);
            }
            return stockOrders;
        }
        public static DataTable GetStockOrdersByEmpid(int id)
        {
            string qry = $"select order_id as StockOrderID,Product_Code,Order_date as Date,Action from stockorders where emp_id = '{id}'";
            DataTable dt = DataBaseHelper.GetTable(qry);
            return dt;
        }
        public static DataTable getAllStocks()
        {
            string qry = "select * from VIEW_All_Stocks";
            DataTable dt = DataBaseHelper.GetTable(qry);
            return dt;
        }
        public static void Add(string pcode, int stock, StockOrderBL so)
        {
            string qry = $"update products set in_stock = in_stock + {stock} where product_code = '{pcode}'";
            DataBaseHelper.ExecuteDML(qry);
            string qry2 = $"insert into stockorders (emp_id, product_code, order_date,action) values ({so.employee_id}, '{pcode}', '{so.order_date}','ADDED')";
            DataBaseHelper.ExecuteDML(qry2);
        }
        public static void Reduce(string pcode, int stock, StockOrderBL so)
        {
            string qry = $"update products set in_stock = in_stock - {stock} where product_code = '{pcode}'";
            DataBaseHelper.ExecuteDML(qry);
            string qry2 = $"insert into stockorders (emp_id, product_code, order_date,action) values ({so.employee_id}, '{pcode}', '{so.order_date}','REDUCED')";
            DataBaseHelper.ExecuteDML(qry2);
        }
        public static void Update(string pcode, int stock, StockOrderBL so)
        {
            string qry = $"update products set in_stock = {stock} where product_code = '{pcode}'";
            DataBaseHelper.ExecuteDML(qry);
            string qry2 = $"insert into stockorders (emp_id, product_code, order_date,action) values ({so.employee_id}, '{pcode}', '{so.order_date}','UPDATED')";
            DataBaseHelper.ExecuteDML(qry2);
        }
    }
}
