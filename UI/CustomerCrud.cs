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
    public partial class CustomerCrud : UserControl
    {
        public CustomerCrud()
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
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerBL customer = new CustomerBL((int)employeeView.CurrentRow.Cells[0].Value, name.Text, phone.Text, Address.Text);
                CustomerDL.UpdateCustomer(customer);
                MessageBox.Show("Customer updated successfully.");
                getRows();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                employeeView.DataSource = CustomerDL.SearchCustomer(textBox2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void employeeView_Click(object sender, EventArgs e)
        {
            name.Text = employeeView.SelectedRows[0].Cells[1].Value.ToString();
            phone.Text = employeeView.SelectedRows[0].Cells[2].Value.ToString();
            Address.Text = employeeView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
    }
}
