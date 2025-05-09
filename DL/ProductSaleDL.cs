using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class ProductSaleDL
    {
        public static List<ProductSaleBL> GetProductSales()
        {
            string qry = "SELECT p.product_code AS Code,p.name AS Name,COALESCE(SUM(bd.qty), 0) AS total_sold,COALESCE(SUM(bd.total_price), 0) AS revenue FROM products p LEFT JOIN billdetails bd ON p.product_code = bd.product_code LEFT JOIN bills b ON bd.bill_id = b.bill_id AND b.deleted = 0 GROUP BY p.product_code, p.name ORDER BY code DESC";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<ProductSaleBL> productSales = new List<ProductSaleBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string code = (dr["Code"]).ToString();
                string name = (dr["Name"]).ToString();
                int quantitySold = Convert.ToInt32(dr["total_sold"]);
                double totalSaleAmount = Convert.ToDouble(dr["revenue"]);
                ProductSaleBL p = new ProductSaleBL(code, name, quantitySold, totalSaleAmount);
                productSales.Add(p);
            }
            return productSales;
        }
        public static List<ProductSaleBL> GetProductSalesTop10()
        {
            string qry = "SELECT p.product_code AS Code,p.name AS Name,COALESCE(SUM(bd.qty), 0) AS total_sold,COALESCE(SUM(bd.total_price), 0) AS revenue FROM products p LEFT JOIN billdetails bd ON p.product_code = bd.product_code LEFT JOIN bills b ON bd.bill_id = b.bill_id AND b.deleted = 0 GROUP BY p.product_code, p.name ORDER BY code DESC LIMIT 10";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<ProductSaleBL> productSales = new List<ProductSaleBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string code = (dr["Code"]).ToString();
                string name = (dr["Name"]).ToString();
                int quantitySold = Convert.ToInt32(dr["total_sold"]);
                double totalSaleAmount = Convert.ToDouble(dr["revenue"]);
                ProductSaleBL p = new ProductSaleBL(code, name, quantitySold, totalSaleAmount);
                productSales.Add(p);
            }
            return productSales;
        }
    }
}
