using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class BillReportItem
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity;
        public BillReportItem(string productName, decimal unitPrice, int quantity)
        {
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
