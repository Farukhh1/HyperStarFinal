using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class ProductSaleBL
    {
        public string code { get; set; }
        public string Name { get; set; }
        public int QuantitySold { get; set; }
        public double TotalSaleAmount { get; set; }
        public ProductSaleBL(string code, string name, int quantitySold, double totalSaleAmount)
        {
            this.code = code;
            Name = name;
            QuantitySold = quantitySold;
            TotalSaleAmount = totalSaleAmount;
        }
    }
}
