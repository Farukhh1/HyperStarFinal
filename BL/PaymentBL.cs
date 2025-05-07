using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class PaymentBL
    {
        public int PaymentID { get; set; }
        public int BillID { get; set; }
        public decimal CashReceived { get; set; }

        public PaymentBL(int paymentID, int billID, decimal cashReceived)
        {
            PaymentID = paymentID;
            BillID = billID;
            CashReceived = cashReceived;
        }
    }
}
