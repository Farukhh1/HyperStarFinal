using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    public class EmployeeDL
    {
        static public void addEmployee(EmployeeBL employeeBl)
        {
            string query = $"INSERT INTO employees (fullname, username, passw, role_id, dept_id) VALUES ('{employeeBl.Name}', '{employeeBl.username}', '{employeeBl.password}', '{employeeBl.role_id}', '{employeeBl.dept_id}');";
            DataBaseHelper.ExecuteDML(query);
        }
        static public void deleteEmployee(int id)
        {
            string query = $"DELETE FROM employees where employee_id = '{id}'";
            DataBaseHelper.ExecuteDML(query);
        }
        static public void updateEmployee(EmployeeBL employeeBl)
        {
            string query = $"UPDATE employees SET fullname = '{employeeBl.Name}', username = '{employeeBl.username}', passw = '{employeeBl.password}', role_id = '{employeeBl.role_id}', dept_id = '{employeeBl.dept_id}' WHERE employee_id = '{employeeBl.ID}';";
            DataBaseHelper.ExecuteDML(query);
        }
        static public DataTable getAllEmployees()
        {
            string query = "SELECT employee_id,fullname, username, passw, role_name, dept_name FROM roles natural join employees natural join departments;";
            DataTable dt = DataBaseHelper.GetTable(query);
            return dt;
        }
        static public DataTable getRole()
        {
            string query = "SELECT role_name FROM roles";
            DataTable dt = DataBaseHelper.GetTable(query);
            return dt;
        }
        static public DataTable getDept()
        {
            string query = "SELECT dept_name FROM departments";
            DataTable dt = DataBaseHelper.GetTable(query);
            return dt;
        }
        public static EmployeeBL CheckUser(string username, string password)
        {
            string query = $"SELECT * FROM employees WHERE username = '{username}' AND passw = '{password}'";
            DataTable dt = DataBaseHelper.GetTable(query);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                int id = Convert.ToInt32(dt.Rows[0]["employee_id"]);
                string name = dt.Rows[0]["fullname"].ToString();
                string user = dt.Rows[0]["username"].ToString();
                string pass = dt.Rows[0]["passw"].ToString();
                int role_id = Convert.ToInt32(dt.Rows[0]["role_id"]);
                int dept_id = Convert.ToInt32(dt.Rows[0]["dept_id"]);
                EmployeeBL employeeBl = new EmployeeBL(id, name, user, pass, role_id, dept_id);
                return employeeBl;
            }

        }
    }
}
