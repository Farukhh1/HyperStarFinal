using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.Reports;

namespace HyperstarManagementSystem
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 580);
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void employeeCrud1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            EmployeeCrud employeeControl = new EmployeeCrud();
            employeeControl.Dock = DockStyle.Fill;

            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(employeeControl);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.mainContentPanel.Controls.Clear();
            Report report = new Report();
            report.Dock = DockStyle.Fill;

            // Add it to the container panel (assumed named mainContentPanel)
            this.mainContentPanel.Controls.Add(report);
        }

        private void mainContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Shapes3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        // Handle resizing
        //    this.Resize += (s, e) => CenterLoginPanel();
        //}

        //private void CenterLoginPanel()
        //        {
        //            loginPanel.Left = (mainContentPanel.Width - loginPanel.Width) / 2;
        //            loginPanel.Top = (mainContentPanel.Height - loginPanel.Height) / 2;
        //        }
    }
}
