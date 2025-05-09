using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class SupplierBL
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public SupplierBL(int supplierID, string supplierName, string city, string contact)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            City = city;
            Contact = contact;
        }
        public SupplierBL(string supplierName, string city, string contact)
        {
            SupplierName = supplierName;
            City = city;
            Contact = contact;
        }
    }
}
