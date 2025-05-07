using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class ProductBL
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int in_stock { get; set; }
        public int supplierID { get; set; } 
        public string manufacturer { get; set; }
        public int dept_id { get; set; }
        public ProductBL(string productCode, string productName, decimal price, int in_stock, int supplierID, string manufacturer, int dept_id)
        {
            ProductCode = productCode;
            ProductName = productName;
            Price = price;
            this.in_stock = in_stock;
            this.supplierID = supplierID;
            this.manufacturer = manufacturer;
            this.dept_id = dept_id;
        }   
    }
}
