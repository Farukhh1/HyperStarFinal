using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class BillsBL
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public string BillDate { get; set; }
        public decimal TotalAmount { get; set; }
        public List<BillDetailBL> BillDetails { get; set; }

        public BillsBL(int billID, int customerID, int employeeID, string billDate, decimal totalAmount, List<BillDetailBL> billDetails)
        {
            BillID = billID;
            CustomerID = customerID;
            EmployeeID = employeeID;
            BillDate = billDate;
            TotalAmount = totalAmount;
            BillDetails = billDetails;
        }
    }
}
