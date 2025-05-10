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

namespace HyperstarManagementSystem
{
    public partial class ProductsView : UserControl
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            ProductView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ProductView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
            ProductView.DataSource = ProductDL.GetAllProducts();
        }

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
