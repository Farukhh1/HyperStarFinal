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
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.UI
{
    public partial class StockOrders : UserControl
    {
        public EmployeeBL emp = null;
        public StockOrders(EmployeeBL emp)
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void StockOrders_Load(object sender, EventArgs e)
        {
            StockOrdersView.DataSource = StockOrderDL.GetStockOrdersByEmpid(emp.ID);
            StockOrdersView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            StockOrdersView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StockOrdersView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            StockOrdersView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
        }

        private void StockOrders_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                StockOrdersView.DataSource = null;
                StockOrdersView.DataSource = StockOrderDL.GetStockOrdersByEmpid(emp.ID);

            }
        }

        private void StockOrdersView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
