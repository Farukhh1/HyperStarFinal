using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HyperstarManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();

        }

        private void greenPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
