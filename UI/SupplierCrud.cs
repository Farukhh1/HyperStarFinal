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
    public partial class SupplierCrud : UserControl
    {
        public SupplierCrud()
        {
            InitializeComponent();
        }

        private void SupplierView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void ShowRows()
        {
            try
            {
                SupplierView.DataSource = null;
                SupplierView.DataSource = SupplierDL.GetAll();
                SupplierView.Columns[0].Visible = false;
                SupplierView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SupplierView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                SupplierView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                SupplierView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && contact.Text != "" && city.Text != "")
            {
                try
                {
                    string supplierName = name.Text.ToString();
                    string supplierPhone = "+92-" + contact.Text.ToString();
                    string supplierAddress = city.Text.ToString();
                    SupplierBL sp = new SupplierBL(supplierName, supplierAddress, supplierPhone);
                    SupplierDL.Add(sp);
                    MessageBox.Show("Supplier added successfully");
                    ShowRows();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (name.Text != "" && contact.Text != "" && city.Text != "")
            {
                try
                {
                    int supplierID = Convert.ToInt32(SupplierView.SelectedRows[0].Cells[0].Value);
                    string supplierName = name.Text.ToString();
                    string supplierPhone = contact.Text.ToString();
                    string supplierAddress = city.Text.ToString();
                    SupplierBL sp = new SupplierBL(supplierID, supplierName, supplierAddress, supplierPhone);
                    SupplierDL.Update(sp);
                    MessageBox.Show("Supplier updated successfully");
                    ShowRows();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all fields");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                int supplierID = Convert.ToInt32(SupplierView.SelectedRows[0].Cells[0].Value);
                SupplierDL.Delete(supplierID);
                MessageBox.Show("Supplier deleted successfully");
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            try
            {
                name.Clear();
                contact.Clear();
                city.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void SupplierCrud_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                try
                {
                    name.Clear();
                    contact.Clear();
                    city.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void SupplierCrud_Load(object sender, EventArgs e)
        {
            ShowRows();
        }
    }
}
