using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class StockOrderBL
    {
        public int order_id { get; set; }
        public int employee_id { get; set; }
        public string product_code { get; set; }
        public string order_date { get; set; }
        public string Action { get; set; }
        public StockOrderBL(int order_id, int employee_id, string product_code, string order_date,string Action)
        {
            this.order_id = order_id;
            this.employee_id = employee_id;
            this.product_code = product_code;
            this.order_date = order_date;
            this.Action = Action;
        }
        public StockOrderBL(int employee_id, string product_code, string order_date, string Action)
        {
            this.employee_id = employee_id;
            this.product_code = product_code;
            this.order_date = order_date;
            this.Action = Action;
        }
    }
}
