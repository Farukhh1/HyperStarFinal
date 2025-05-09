using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.UI;

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
            this.mainContentPanel.Controls.Add(productControl);
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
            this.mainContentPanel.Controls.Add(productControl);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login login = new Login();
            login.Show();
        }

        private void Products_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            ProductCrud productControl = new ProductCrud();
            productControl.Dock = DockStyle.Fill;
            this.mainContentPanel.Controls.Add(productControl);
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            Departments departments = new Departments();
            departments.Dock = DockStyle.Fill;
            this.mainContentPanel.Controls.Add(departments);
        }

        private void EmployeeCrudButton_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
    }
}
