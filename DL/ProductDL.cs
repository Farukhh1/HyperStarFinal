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
        public static List<ProductReport> GetAllProducts()
        {
            string qry = "SELECT p.product_code,p.name AS name,p.price,p.in_stock,s.name AS Sname, p.manufacturer,d.dept_name FROM products p JOIN suppliers s ON p.supplier_id = s.supplier_id JOIN departments d ON p.dept_id = d.dept_id WHERE p.deleted = 0;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<ProductReport> products = new List<ProductReport>();
            foreach (DataRow dr in dt.Rows)
            {
                string productCode = dr["product_code"].ToString();
                string productName = dr["name"].ToString();
                decimal price = Convert.ToDecimal(dr["price"]);
                int in_stock = Convert.ToInt32(dr["in_stock"]);
                string supplierID = dr["Sname"].ToString();
                string manufacturer = dr["manufacturer"].ToString();
                string dept_id = dr["dept_name"].ToString();
                ProductReport p = new ProductReport(productCode, productName, price, in_stock, supplierID, manufacturer, dept_id);
                products.Add(p);
            }
            return products;
        }
        public static List<InactiveProductBL> GetAllInactiveProducts()
        {
            string qry = "SELECT p.product_code,p.name AS name,p.price,p.in_stock,s.name AS Sname, p.manufacturer,d.dept_name FROM products p JOIN suppliers s ON p.supplier_id = s.supplier_id JOIN departments d ON p.dept_id = d.dept_id WHERE p.deleted = 1;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<InactiveProductBL> products = new List<InactiveProductBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string productCode = dr["product_code"].ToString();
                string productName = dr["name"].ToString();
                decimal price = Convert.ToDecimal(dr["price"]);
                int in_stock = Convert.ToInt32(dr["in_stock"]);
                string supplierID = dr["Sname"].ToString();
                string manufacturer = dr["manufacturer"].ToString();
                string dept_id = dr["dept_name"].ToString();
                InactiveProductBL p = new InactiveProductBL(productCode, productName, price, in_stock, supplierID, manufacturer, dept_id);
                products.Add(p);
            }
            return products;
        }
        public static int getDeptIdByName(string deptName)
        {
            string qry = $"select dept_id from departments where dept_name = '{deptName}'";
            DataTable dt = DataBaseHelper.GetTable(qry);

            return Convert.ToInt32(dt.Rows[0][0]);

        }
        public static List<string> GetAllManufacturers()
        {
            string qry = $"select m_name from manufacturers";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<string> manufacturers = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                string manufacturer = dr["m_name"].ToString();
                manufacturers.Add(manufacturer);
            }
            return manufacturers;
        }
        public static void Add(ProductBL p)
        {
            string qry = $"insert into products (product_code, name, price, in_stock, supplier_id, manufacturer, dept_id) values ('{p.ProductCode}', '{p.ProductName}', {p.Price}, {p.In_Stock}, {p.supplierID}, '{p.manufacturer}', {p.dept_id})";
            DataBaseHelper.ExecuteDML(qry);
        }
        public static void Update(ProductBL p)
        {
            string qry = $"update products set name = '{p.ProductName}', price = {p.Price}, supplier_id = {p.supplierID}, manufacturer = '{p.manufacturer}', dept_id = {p.dept_id} where product_code = '{p.ProductCode}'";
            DataBaseHelper.ExecuteDML(qry);
        }
        public static void Delete(string productCode)
        {
            string qry = $"update products set deleted = 1 where product_code = '{productCode}'";
            DataBaseHelper.ExecuteDML(qry);
        }
    }
}
