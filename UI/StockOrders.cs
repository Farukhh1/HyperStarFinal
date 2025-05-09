using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.DL;

namespace HyperstarManagementSystem.UI
{
    public partial class StockOrders : UserControl
    {
        public StockOrders()
        {
            InitializeComponent();
        }

        private void StockOrders_Load(object sender, EventArgs e)
        {
            StockOrdersView.DataSource = StockOrderDL.GetStockOrdersByEmpid(1);
        }

        private void StockOrders_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StockOrdersView.DataSource = null;
                StockOrdersView.DataSource = StockOrderDL.GetStockOrdersByEmpid(1);

            }
        }
    }
}
