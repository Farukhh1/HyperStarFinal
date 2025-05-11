using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.Report;

namespace HyperstarManagementSystem.UI
{
    public partial class Cashier : Form
    {
        public Cashier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private Guna.UI2.WinForms.Guna2Button lastClickedButton = null;


        private void ToggleButtonColor(Guna.UI2.WinForms.Guna2Button clickedButton)
        {
            if (lastClickedButton != null && lastClickedButton != clickedButton)

            {
                lastClickedButton.FillColor = Color.Green;
                lastClickedButton.ForeColor = Color.White;
            }


            clickedButton.FillColor = Color.White;
            clickedButton.ForeColor = Color.Green;


            lastClickedButton = clickedButton;
        }

        private void EmployeeCrudButton_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            BillView billView = new BillView();
            billView.Dock = DockStyle.Fill;
            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(billView);
            ToggleButtonColor((Guna.UI2.WinForms.Guna2Button)sender);

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
            ToggleButtonColor((Guna.UI2.WinForms.Guna2Button)sender);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            BillCrud BillControl = new BillCrud();
            BillControl.Dock = DockStyle.Fill;

            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(BillControl);
            ToggleButtonColor((Guna.UI2.WinForms.Guna2Button)sender);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            ProductsView productsView = new ProductsView();
            productsView.Dock = DockStyle.Fill;
            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(productsView);
            ToggleButtonColor((Guna.UI2.WinForms.Guna2Button)sender);
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
