using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class BillReportBL
    {
        public int BillID { get; set; }
        public DateTime BillDate { get; set; }
        public string CustomerName { get; set; }
        public string EmployeeName { get; set; }

        public List<BillReportItem> Items { get; set; } = new List<BillReportItem>();

        public decimal TotalAmount { get; set; }
        public decimal CashReceived { get; set; }
        public decimal Change => CashReceived - TotalAmount;
        public BillReportBL(int billID, DateTime billDate, string customerName, string employeeName, List<BillReportItem> items, decimal totalAmount, decimal cashReceived)
        {
            BillID = billID;
            BillDate = billDate;
            CustomerName = customerName;
            EmployeeName = employeeName;
            Items = items;
            TotalAmount = totalAmount;
            CashReceived = cashReceived;
        }
        public BillReportBL()
        {

        }
    }
}
