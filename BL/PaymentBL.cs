using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class PaymentBL
    {
        public int BillID { get; set; }
        public decimal CashReceived { get; set; }

        public PaymentBL(int billID, decimal cashReceived)
        {
            BillID = billID;
            CashReceived = cashReceived;
        }
        public PaymentBL(decimal cashReceived)
        {
            CashReceived = cashReceived;
        }
    }
}
