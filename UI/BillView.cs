using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.BL;
using HyperstarManagementSystem.Report;

namespace HyperstarManagementSystem.UI
{
    public partial class BillView : UserControl
    {
        public EmployeeBL emp = null;
        public BillView(EmployeeBL emp)
        {
            InitializeComponent();
            this.emp = emp;
            getRows();
        }
        public BillView()
        {
            InitializeComponent();
        }
        private void getRows()
        {
            if(emp == null)
            {
                employeeView.DataSource = BillsDL.GetBillViewTable();
            }
            else
            {
                employeeView.DataSource = BillsDL.GetBillViewTable(emp.ID);
            }
            employeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employeeView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employeeView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 8, FontStyle.Bold);
        }
        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillDetails_Click(object sender, EventArgs e)
        {
            if (BillDetails.Text == "Details")
            {
                employeeView.DataSource = BillDetailDL.GetBilldetailsByBillID((int)employeeView.CurrentRow.Cells[0].Value);
                employeeView.Columns[0].Visible = false;
                employeeView.Columns[1].Visible = false;
                BillDetails.Text = "Back";
            }
            else
            {
                getRows();
                BillDetails.Text = "Details";
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as Cashier;
            if (form != null)
            {
                form.LoadUserControl(new BillReport((int)employeeView.CurrentRow.Cells[0].Value));
            }
        }
    }
}
