using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperstarManagementSystem.UI
{
    public partial class BillView : UserControl
    {
        public BillView()
        {
            InitializeComponent();
            getRows();
        }
        private void getRows()
        {
            employeeView.DataSource = BillsDL.GetAll();
        }
        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BillDetails_Click(object sender, EventArgs e)
        {
            if (BillDetails.Text == "Details")
            {
                employeeView.DataSource = BillDetailDL.GetBilldetailsByBillID((int)employeeView.CurrentRow.Cells[0].Value);
                BillDetails.Text = "Back";
            }
            else
            {
                getRows();
                BillDetails.Text = "Details";
            }
        }
    }
}
