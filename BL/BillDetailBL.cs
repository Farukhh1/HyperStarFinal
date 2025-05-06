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
        public int billID { get; set; }
        public int productCode { get; set; }
        public int quantity { get; set; }
        public decimal totalPrice { get; set; }

        public BillDetailBL(int billdetailID, int billID, int productCode, int quantity, decimal totalPrice)
        {
            this.billdetailID = billdetailID;
            this.billID = billID;
            this.productCode = productCode;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
        }
    }
}
