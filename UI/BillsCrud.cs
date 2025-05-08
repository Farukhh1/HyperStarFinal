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
    public partial class BillsCrud : UserControl
    {
        BillsBL bill = null;
        List<BillDetailBL> cart = new List<BillDetailBL>();
        public BillsCrud()
        {
            InitializeComponent();
        }
        private void ShowRows()
        {
            try
            {
                employeeView.DataSource = null;
                employeeView.DataSource = cart;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void employeeView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string prodCode = productCode.Text.ToString();
                int qty = Convert.ToInt32(quantity.Text);
                BillDetailBL billDetail = new BillDetailBL(prodCode, qty);
                cart.Add(billDetail);
                ShowRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            PaymentBL paymentt = new PaymentBL(2000);
            bill = new BillsBL(1,1,dateTimePicker1.Value.ToString("yyyy-MM-dd"),cart,paymentt);
            if (BillsDL.SaveBillTransaction(bill))
            {
                MessageBox.Show("Bill Saved Successfully");
            }
            else
            {
                MessageBox.Show("Bill Not Saved");
            }
        }
    }
}
