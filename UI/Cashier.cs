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
    public partial class Cashier : Form
    {
        public EmployeeBL emp = null;
        public Cashier(EmployeeBL emp)
        {
            InitializeComponent();
            this.emp = emp;
            label8.Text = emp.username;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeCrudButton_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            BillView billView = new BillView(emp);
            billView.Dock = DockStyle.Fill;
            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(billView);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

            this.mainContentPanel.Controls.Clear();
            CustomerAdd customeradd = new CustomerAdd();
            customeradd.Dock = DockStyle.Fill;

            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(customeradd);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            BillCrud BillControl = new BillCrud(emp);
            BillControl.Dock = DockStyle.Fill;

            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(BillControl);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            ProductsView productsView = new ProductsView();
            productsView.Dock = DockStyle.Fill;
            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(productsView);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.Show();
        }
        public void LoadUserControl(UserControl uc)
        {
            this.mainContentPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            this.mainContentPanel.Controls.Add(uc);
            
        }

    }
}
