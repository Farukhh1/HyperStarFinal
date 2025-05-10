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

namespace HyperstarManagementSystem
{
    public partial class ProductCrud : UserControl
    {
        public ProductCrud()
        {
            InitializeComponent();
        }

        private void ProductCrud_Load(object sender, EventArgs e)
        {
            ShowRows();
            cbManufacturer.DataSource = ProductDL.GetAllManufacturers();
            cbSupplier.DataSource = SupplierDL.GetAllNames();
            cbManufacturer.Text = "Select";
            cbSupplier.Text = "Select";

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbPCode.Text.ToString();
                string productName = tbName.Text.ToString();
                decimal price = Convert.ToDecimal(tbPrice.Text.ToString());
                int in_stock = Convert.ToInt32(tbStock.Text.ToString());
                int supplierID = SupplierDL.GetID(cbSupplier.SelectedItem.ToString());
                string manufacturer = cbManufacturer.SelectedItem.ToString();
                int dept_id = ProductDL.getDeptIdByName(dept.SelectedItem.ToString());
                ProductBL p = new ProductBL(productCode, productName, price, in_stock, supplierID, manufacturer, dept_id);
                ProductDL.Add(p);
                MessageBox.Show("Product added successfully");
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ShowRows()
        {
            try
            {
                ProductView.DataSource = null;
                ProductView.DataSource = ProductDL.GetAllProducts();
                ProductView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ProductView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ProductView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                ProductView.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbPCode.Text.ToString();
                ProductDL.Delete(productCode);
                MessageBox.Show("Product deleted successfully");
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbPCode.Text.ToString();
                string productName = tbName.Text.ToString();
                decimal price = Convert.ToDecimal(tbPrice.Text.ToString());
                int in_stock = Convert.ToInt32(tbStock.Text.ToString());
                int supplierID = SupplierDL.GetID(cbSupplier.SelectedItem.ToString());
                string manufacturer = cbManufacturer.SelectedItem.ToString();
                int dept_id = ProductDL.getDeptIdByName(dept.SelectedItem.ToString());
                ProductBL p = new ProductBL(productCode, productName, price, in_stock, supplierID, manufacturer, dept_id);
                ProductDL.Update(p);
                MessageBox.Show("Product updated successfully");
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
                tbPCode.Clear();
                tbName.Clear();
                tbPrice.Clear();
                tbStock.Clear();
                cbSupplier.Text = "Select";
                cbManufacturer.Text = "Select";
                dept.Text = "Select";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProductCrud_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == true)
            {
                try
                {
                    tbPCode.Clear();
                    tbName.Clear();
                    tbPrice.Clear();
                    tbStock.Clear();
                    cbSupplier.Text = "Select";
                    cbManufacturer.Text = "Select";
                    dept.Text = "Select";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void ProductView_Click(object sender, EventArgs e)
        {
            tbPCode.Text = ProductView.SelectedRows[0].Cells[0].Value.ToString();
            tbName.Text = ProductView.SelectedRows[0].Cells[1].Value.ToString();
            tbPrice.Text = ProductView.SelectedRows[0].Cells[2].Value.ToString();
            tbStock.Text = ProductView.SelectedRows[0].Cells[3].Value.ToString();
            cbSupplier.Text = "Select";
            cbManufacturer.Text = "Select";
            dept.Text = "Select";
        }

        private void ProductView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
