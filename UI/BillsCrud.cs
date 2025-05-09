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
        public bool Finish = true;
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
                BillView.DataSource = null;
                BillView.DataSource = cart;

                BillView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                BillView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                BillView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // Set Column Header Font Size (Optional)
                BillView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click_1(object sender, EventArgs e)
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
        private void guna2Button2_Click(object sender, EventArgs e)
        {
          
        }

        private void BillsCrud_Load(object sender, EventArgs e)
        {
            Visibility();
            ShowRows();
        }
        public void Visibility()
        {
            if(Finish)
            {
                label2.Visible = true;
                label4.Visible = true;
                productCode.Visible = true;
                quantity.Visible = true;
                Next.Visible = true;

                btnFinish.Visible = false;
                Response.Visible = false;
                Responseee.Visible = false;
                CashRec.Visible = false;
                CashR.Visible=false;
                Contactt.Visible = false;
                contact.Visible=false;
            }
            else
            {
                label2.Visible = false;
                label4.Visible = false;
                productCode.Visible = false;
                quantity.Visible = false;
                Next.Visible = false;

                btnFinish.Visible = true;
                Response.Visible =true;
                Responseee.Visible = true;
                CashRec.Visible = true;
                CashR.Visible = true;
                Contactt.Visible = true;
                contact.Visible = true;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

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
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            PaymentBL paymentt = new PaymentBL(2000);
            bill = new BillsBL(1, 1, dateTimePicker1.Value.ToString("yyyy-MM-dd"), cart, paymentt);
            if (BillsDL.SaveBillTransaction(bill))
            {
                MessageBox.Show("Bill Saved Successfully");
            }
            else
            {
                MessageBox.Show("Bill Not Saved");
            }

        }

        private void Next_Click_1(object sender, EventArgs e)
        {
            //if (cart.Count == 0)
            //{
            //    MessageBox.Show("No items in cart. Please add products first.");
            //    return;
            //}
            Finish = !Finish;
            Visibility();
        }
    }
}
