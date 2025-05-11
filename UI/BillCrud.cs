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
using HyperstarManagementSystem.Report;

namespace HyperstarManagementSystem.UI
{
    public partial class BillCrud : UserControl
    {
        public bool btnClick = false;
        private BillsBL currentBill = null;
        private List<BillDetailBL> cart = new List<BillDetailBL>();
        EmployeeBL emp = null;
        public void DefaultVisibility()
        {
            ProductCodeL.Visible = true;
            CodeT.Visible = true;
            QuantityL.Visible = true;
            quantityT.Visible = true;
            dateTimePicker1.Visible = true;
            cmbSearchProduct.Visible = true;
            guna2Button2.Visible = true;
            NextButton.Visible = true;
            AddButton.Visible = true;
            DeleteButton.Visible = true;
            UpdateButton.Visible = true;
            ClearButton.Visible = true;
            DateLabel.Visible = true;



            FinishB.Visible = false;
            ContactL.Visible = false;
            ContactT.Visible = false;
            ResponseL.Visible = false;
            ResponseT.Visible = false;
            CashRecievedL.Visible = false;
            CashRecievedT.Visible = false;
            label3.Visible = false;

        }

        public void changeVisibility()
        {
            ProductCodeL.Visible = false;
            CodeT.Visible = false;
            QuantityL.Visible = false;
            quantityT.Visible = false;
            dateTimePicker1.Visible = false;
            cmbSearchProduct.Visible = false;
            guna2Button2.Visible = false;
            NextButton.Visible = false;
            AddButton.Visible = false;
            DeleteButton.Visible = false;
            UpdateButton.Visible = false;
            ClearButton.Visible = false;
            DateLabel.Visible = false;


            FinishB.Visible = true;
            ContactL.Visible = true;
            ContactT.Visible = true;
            ResponseL.Visible = true;
            ResponseT.Visible = true;
            CashRecievedL.Visible = true;
            CashRecievedT.Visible = true;
            label3.Visible = true;
        }
        public BillCrud(EmployeeBL emp)
        {
            InitializeComponent();
            DefaultVisibility();
            this.emp = emp;
        }

        private void ShowDetails()
        {
            try
            {
                BillViewPanel.DataSource = null;
                BillViewPanel.DataSource = cart;
                BillViewPanel.Columns["ProductCode"].HeaderText = "Product Code";
                BillViewPanel.Columns[0].Visible = false;
                BillViewPanel.Columns[1].Visible = false;
                BillViewPanel.Columns[4].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BillCrud_Load(object sender, EventArgs e)
        {
            DefaultVisibility();
            BillViewPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BillViewPanel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BillViewPanel.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            BillViewPanel.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Bold);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FinishB_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            btnClick = true;
        }



        private void NextButton_Click_2(object sender, EventArgs e)
        {
            if (cart.Count != 0)
            {
                string pcode = CodeT.Text;
                changeVisibility();

            }
            else
            {
                MessageBox.Show("Please add products to the bill.");
            }
        }

        private void FinishB_Click_1(object sender, EventArgs e)
        {
            if (ContactT.Text != "" && CashRecievedT.Text != "" && ResponseT.Text != "")
            {
                try
                {
                    int customerID = CustomerDL.getCustomerIdByPhone("+92-" + ContactT.Text.ToString());
                    decimal cashRecieved = Convert.ToDecimal(CashRecievedT.Text.ToString());
                    string response = ResponseT.Text.ToString();
                    string billDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                    PaymentBL paym = new PaymentBL(cashRecieved);
                    currentBill = new BillsBL(customerID, emp.ID, billDate, cart, paym, response);
                    if (BillsDL.SaveBillTransaction(currentBill))
                    {
                        MessageBox.Show("Bill Saved Successfully");
                        DefaultVisibility();
                        cart.Clear();

                    }
                    else
                    {
                        MessageBox.Show("Error in saving bill");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void BillViewPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            bool entered = false;
            if (CodeT.Text != "" && quantityT.Text != "")
            {
                try
                {
                    string pcode = CodeT.Text.ToString();
                    foreach (BillDetailBL bdt in cart)
                    {
                        if (bdt.ProductCode == pcode)
                        {
                            bdt.Quantity += Convert.ToInt32(quantityT.Text.ToString());
                            ShowDetails();
                            entered = true;
                            break;
                        }
                    }
                    if (entered == false)
                    {
                        if (ProductDL.productExists(pcode))
                        {
                            int quantity = Convert.ToInt32(quantityT.Text.ToString());
                            BillDetailBL billDetail = new BillDetailBL(pcode, quantity);
                            cart.Add(billDetail);
                            ShowDetails();
                        }
                        else
                        {
                            MessageBox.Show("Product does not exist.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CodeT.Text != "")
            {
                try
                {
                    string pcode = CodeT.Text.ToString();
                    if (ProductDL.productExists(pcode))
                    {
                        foreach (BillDetailBL bd in cart)
                        {
                            if (bd.ProductCode == pcode)
                            {
                                cart.Remove(bd);
                                break;
                            }
                        }
                        ShowDetails();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please specify Product Code.");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CodeT.Clear();
            quantityT.Clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CodeT.Text != "")
            {
                try
                {
                    string pcode = CodeT.Text.ToString();
                    if (ProductDL.productExists(pcode))
                    {
                        foreach (BillDetailBL bd in cart)
                        {
                            if (bd.ProductCode == pcode)
                            {
                                int qty = Convert.ToInt32(quantityT.Text.ToString());
                                bd.Quantity = qty;
                                break;
                            }
                        }
                        ShowDetails();
                    }
                    else
                    {
                        MessageBox.Show("Product does not exist.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string input = cmbSearchProduct.Text.Trim();
            List<string> matches = ProductDL.GetMatchingProductCodes(input);

            cmbSearchProduct.Items.Clear();
            foreach (string code in matches)
            {
                cmbSearchProduct.Items.Add(code);
            }

            if (cmbSearchProduct.Items.Count > 0)
            {
                cmbSearchProduct.DroppedDown = true;
            }
        }

        private void cmbSearchProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                CodeT.Text = cmbSearchProduct.SelectedItem.ToString();
            }
            catch (Exception ex)
            { MessageBox.Show("Error: " + ex.Message); }
        }
    }
}
