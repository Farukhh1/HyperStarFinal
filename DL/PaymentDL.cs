using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class PaymentDL
    {
        public static List<PaymentBL> GetAll()
        {
            string qry = "select * from payments";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<PaymentBL> payments = new List<PaymentBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int paymentID = Convert.ToInt32(dr["paym_id"]);
                int billID = Convert.ToInt32(dr["bill_id"]);
                decimal cashReceived = Convert.ToDecimal(dr["cash_rec"]);
                PaymentBL p = new PaymentBL(paymentID, billID, cashReceived);
                payments.Add(p);
            }
            return payments;
        }

    }
}
