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
using HyperstarManagementSystem.DL;

namespace HyperstarManagementSystem.UI
{
    public partial class CustomerAdd : UserControl
    {
        public CustomerAdd()
        {
            InitializeComponent();
            getRows();
        }
        private void getRows()
        {
            employeeView.DataSource = CustomerDL.GetCustomer();
            employeeView.Columns[0].Visible = false;
            employeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            employeeView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employeeView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            employeeView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
        }
        private void clear()
        {
            name.Clear();
            phone.Clear();
            Address.Clear();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && phone.Text != "" && Address.Text != "")
            {
                try
                {
                    string phoneNumber = "+92-" + phone.Text.ToString();
                    CustomerBL customer = new CustomerBL(0, name.Text, phoneNumber, Address.Text);
                    CustomerDL.AddCustomer(customer);
                    getRows();
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                employeeView.DataSource = CustomerDL.SearchCustomer(textBox2.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void employeeView_Click(object sender, EventArgs e)
        {
            name.Text = employeeView.CurrentRow.Cells[1].Value.ToString();
            phone.Text = employeeView.CurrentRow.Cells[2].Value.ToString();
            Address.Text = employeeView.CurrentRow.Cells[3].Value.ToString();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
