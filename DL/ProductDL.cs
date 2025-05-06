using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HyperstarManagementSystem.BL;
using System.ComponentModel;

namespace HyperstarManagementSystem.DL
{
    internal class ProductDL
    {
        public static List<ProductBL> GetAll()
        {
            string qry = "select * from products where deleted = 0";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<ProductBL> products = new List<ProductBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string productCode = dr["product_code"].ToString();
                string productName = dr["product_name"].ToString();
                decimal price = Convert.ToDecimal(dr["price"]);
                int in_stock = Convert.ToInt32(dr["in_stock"]);
                int supplierID = Convert.ToInt32(dr["supplierID"]);
                string manufacturer = dr["manufacturer"].ToString();
                int dept_id = Convert.ToInt32(dr["dept_id"]);
                ProductBL p = new ProductBL(productCode, productName, price, in_stock, supplierID, manufacturer, dept_id);
                products.Add(p);
            }
            return products;
        }
        public static void Add(ProductBL p)
        {
            string qry = $"insert into products (product_code, product_name, price, in_stock, supplierID, manufacturer, dept_id) values ('{p.ProductCode}', '{p.ProductName}', {p.Price}, {p.in_stock}, {p.supplierID}, '{p.manufacturer}', {p.dept_id})";
            DataBaseHelper.ExecuteDML(qry);

        }
    }
}
