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
using HyperstarManagementSystem.UI;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                try
                {
                    if(tbUsername.Text == "admin" && tbPassword.Text == "admin")
                    {
                        AdminForm admin = new AdminForm();
                        this.Hide();
                        admin.Show();
                    }
                    else if (EmployeeDL.CheckUser(tbUsername.Text, tbPassword.Text) == null)
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                    else
                    {
                        EmployeeBL emp = EmployeeDL.CheckUser(tbUsername.Text, tbPassword.Text);
                        
                        if (emp.role_id == 1)
                        {
                            Cashier cashr = new Cashier(emp);
                            this.Hide();
                            cashr.Show();
                        }
                        else
                        {
                            InventoryManager inv = new InventoryManager(emp);
                            this.Hide();
                            inv.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter username and password!");
            }

        }

        private void greenPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2CustomCheckBox1_Click(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = guna2CustomCheckBox1.Checked ? '\0' : '*';
        }

        
    }
}
