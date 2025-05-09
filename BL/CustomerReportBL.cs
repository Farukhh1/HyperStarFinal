using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class CustomerReportBL
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; } 
        public int total_bills { get; set; }
        public double total_amount { get; set; }
        public CustomerReportBL(string Name,string Address, string Phone, int total_bills, double total_amount)
        {
            this.Name = Name;
            this.Phone = Phone;
            this.Address = Address;
            this.total_bills = total_bills;
            this.total_amount = total_amount;
        }
    }
}
