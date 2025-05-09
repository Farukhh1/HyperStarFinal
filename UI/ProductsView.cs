using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            // Align Header Text (Center)
            ProductView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Align Cell Text (Center)
            ProductView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Set Column Header Font Size (Optional)
            ProductView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

        }
    }
}
