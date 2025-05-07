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

namespace HyperstarManagementSystem.Reports
{
    public partial class Report : UserControl
    {
        public Report()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ProductDL.GetAllProducts();
            this.reportViewer1.RefreshReport();
        }
    }
}
