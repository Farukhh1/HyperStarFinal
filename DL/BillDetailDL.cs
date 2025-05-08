using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;
using HyperstarManagementSystem.DL;

namespace HyperstarManagementSystem
{
    internal class BillDetailDL
    {
        public static List<BillDetailBL> GetBilldetailsByBillID(int billID)
        {
            string qry = $"select * from billdetails where bill_id = '{billID}'";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<BillDetailBL> billDetails = new List<BillDetailBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int billdetailID = Convert.ToInt32(dr["billdetail_id"]);
                int billId = Convert.ToInt32(dr["bill_id"]);
                string productCode = (dr["product_code"]).ToString();
                int quantity = Convert.ToInt32(dr["qty"]);
                decimal totalPrice = Convert.ToDecimal(dr["total_price"]);
                BillDetailBL b = new BillDetailBL(billdetailID, billId, productCode, quantity, totalPrice);
                billDetails.Add(b);
            }
            return billDetails;
        }
    }
}
