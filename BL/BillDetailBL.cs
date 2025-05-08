using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class BillDetailBL
    {
        public int billdetailID { get; set; }
        public int BillID { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public BillDetailBL(int billdetailID, int billID, string productCode, int quantity, decimal totalPrice)
        {
            this.billdetailID = billdetailID;
            BillID = billID;
            ProductCode = productCode;
            Quantity = quantity;
            TotalPrice = totalPrice;
        }
        public BillDetailBL(string productCode, int quantity)
        {
            ProductCode = productCode;
            Quantity = quantity;
        }
    }
}
