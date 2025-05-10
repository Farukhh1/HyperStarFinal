using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperstarManagementSystem.UI
{
    public partial class BillCrud : UserControl
    {
        public bool btnClick = false;

        public void DefaultVisibility()
        {
            ProductCodeL.Visible = true;
            CodeT.Visible = true;
            QuantityL.Visible = true;
            quantityT.Visible = true;
            dateTimePicker1.Visible = true;
            comboBox1.Visible = true;
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

        }

        public void changeVisibility()
        {
            ProductCodeL.Visible = false;
            CodeT.Visible = false;
            QuantityL.Visible = false;
            quantityT.Visible = false;
            dateTimePicker1.Visible = false;
            comboBox1.Visible = false;
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
        }
        public BillCrud()
        {
            InitializeComponent();
            DefaultVisibility();
           
        }
     

        private void BillCrud_Load(object sender, EventArgs e)
        {
            DefaultVisibility();
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

        private void NextButton_Click_1(object sender, EventArgs e)
        {
            btnClick = true;
            //Panel1.Visible = false;
            //panel2.Visible = true;
            //panel2.BringToFront();
        }

        private void NextButton_Click_2(object sender, EventArgs e)
        {
            changeVisibility();
      
        }

        private void FinishB_Click_1(object sender, EventArgs e)
        {

        }

        private void BillViewPanel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
