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
    public partial class InventoryManager : Form
    {
        public InventoryManager()
        {
            InitializeComponent();
        }

        private void EmployeeCrudButton_Click(object sender, EventArgs e)
        {

            this.mainContentPanel.Controls.Clear();
            ProductCrud productControl = new ProductCrud();


            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(productControl);
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventoryManager_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void ProductCrudButton_Click(object sender, EventArgs e)
        {

            this.mainContentPanel.Controls.Clear();
            ProductCrud productControl = new ProductCrud();


            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(productControl);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }
    }
}
