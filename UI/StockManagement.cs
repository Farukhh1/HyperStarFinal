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
    public partial class StockManagement : UserControl
    {
        public StockManagement()
        {
            InitializeComponent();
        }

        private void StockManagement_Load(object sender, EventArgs e)
        {
            ShowRows();
        }
        private void ShowRows()
        {
            try
            {
                ProductView.DataSource = null;
                ProductView.DataSource = StockOrderDL.getAllStocks();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbPCode.Text.ToString();
                int stk = Convert.ToInt32(tbStock.Text.ToString());
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                StockOrderBL so = new StockOrderBL(1, productCode, date, "ADDED");
                StockOrderDL.Add(productCode, stk, so);
                MessageBox.Show("Stock Added.");
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = tbPCode.Text.ToString();
                int stk = Convert.ToInt32(tbStock.Text.ToString());
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                StockOrderBL so = new StockOrderBL(1, productCode, date, "REDUCED");
                StockOrderDL.Reduce(productCode, stk, so);
                MessageBox.Show("Stock Reduced.");
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
                int stk = Convert.ToInt32(tbStock.Text.ToString());
                string date = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                StockOrderBL so = new StockOrderBL(1, productCode, date, "UPDATED");
                StockOrderDL.Update(productCode, stk, so);
                MessageBox.Show("Stock Updated.");
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ProductView_Click(object sender, EventArgs e)
        {
            tbPCode.Text = ProductView.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tbPCode.Clear();
            tbStock.Clear();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void StockManagement_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                tbPCode.Clear();
                tbStock.Clear();
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
