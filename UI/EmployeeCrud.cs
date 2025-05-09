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
    public partial class EmployeeCrud : UserControl
    {
        public EmployeeCrud()
        {
            InitializeComponent();

            getRows();
        }

        private void getRows()
        {
            DataTable dt = EmployeeDL.getAllEmployees();
            employeeView.DataSource = dt;
            employeeView.Columns[0].Visible = false;
            DataTable dt2 = EmployeeDL.getRole();
            role.DataSource = dt2;
            role.DisplayMember = "role_name";
            DataTable dt3 = EmployeeDL.getDept();
            dept.DataSource = dt3;
            dept.DisplayMember = "dept_name";
            role.SelectedIndex = -1;
            dept.SelectedIndex = -1;

            employeeView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            employeeView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            employeeView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

     
            employeeView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
        }
        private void clear()
        {
            name.Clear();
            username.Clear();
            pwd.Clear();
            role.SelectedIndex = -1;
            dept.SelectedIndex = -1;
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeDL.deleteEmployee(Convert.ToInt32(employeeView.CurrentRow.Cells[0].Value.ToString()));
                MessageBox.Show("Employee Deleted");
                getRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"select role_id from roles where role_name = '{role.Text}'";
                DataTable dt = DataBaseHelper.GetTable(query);
                int role_id = Convert.ToInt32(dt.Rows[0]["role_id"].ToString());
                string query2 = $"select dept_id from departments where dept_name = '{dept.Text}'";
                DataTable dt2 = DataBaseHelper.GetTable(query2);
                int dept_id = Convert.ToInt32(dt2.Rows[0]["dept_id"].ToString());
                try
                {
                    EmployeeBL employeeBL = new EmployeeBL((int)employeeView.CurrentRow.Cells[0].Value, name.Text, username.Text, pwd.Text, role_id, dept_id);
                    EmployeeDL.updateEmployee(employeeBL);
                    MessageBox.Show("Employee Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                getRows();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"select role_id from roles where role_name = '{role.Text}'";
                DataTable dt = DataBaseHelper.GetTable(query);
                int role_id = Convert.ToInt32(dt.Rows[0]["role_id"].ToString());
                string query2 = $"select dept_id from departments where dept_name = '{dept.Text}'";
                DataTable dt2 = DataBaseHelper.GetTable(query2);
                int dept_id = Convert.ToInt32(dt2.Rows[0]["dept_id"].ToString());
                try
                {
                    EmployeeBL employeeBL = new EmployeeBL(0, name.Text, username.Text, pwd.Text, role_id, dept_id);
                    EmployeeDL.addEmployee(employeeBL);
                    MessageBox.Show("Employee Added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                getRows();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void employeeView_Click(object sender, EventArgs e)
        {
            try
            {
                name.Text = employeeView.CurrentRow.Cells[1].Value.ToString();
                username.Text = employeeView.CurrentRow.Cells[2].Value.ToString();
                pwd.Text = employeeView.CurrentRow.Cells[3].Value.ToString();
                role.Text = employeeView.CurrentRow.Cells[4].Value.ToString();
                dept.Text = employeeView.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void EmployeeCrud_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
