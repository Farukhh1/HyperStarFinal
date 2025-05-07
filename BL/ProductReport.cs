using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class ProductReport
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int in_stock { get; set; }
        public string supplier { get; set; }
        public string manufacturer { get; set; }
        public string dept { get; set; }
        public ProductReport(string productCode, string productName, decimal price, int in_stock, string supplier, string manufacturer, string dept)
        {
            ProductCode = productCode;
            ProductName = productName;
            Price = price;
            this.in_stock = in_stock;
            this.supplier = supplier;
            this.manufacturer = manufacturer;
            this.dept = dept;
        }
    }
}
