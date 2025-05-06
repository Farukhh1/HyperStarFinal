using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class BillsBL
    {
        public int billID { get; set; }
        public int customerID { get; set; }
        public int employeeID { get; set; }
        public string billDate { get; set; }
        public decimal totalAmount { get; set; }
        public List<BillDetailBL> billDetails { get; set; }
        public BillsBL(int billID, int customerID, int employeeID, string billDate, decimal totalAmount, List<BillDetailBL> billDetails)
        {
            this.billID = billID;
            this.customerID = customerID;
            this.employeeID = employeeID;
            this.billDate = billDate;
            this.totalAmount = totalAmount;
            this.billDetails = billDetails;
        }
    }
}
