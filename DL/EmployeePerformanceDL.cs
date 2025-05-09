using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class EmployeePerformanceDL
    {
        public static List<EmployeePerformanceBL> GetEmployeePerformance()
        {
            string qry = "SELECT e.fullname,e.username,departments.dept_name,COALESCE(SUM(b.totalamount), 0) AS total_sales,COALESCE(SUM(b.totalamount), 0) AS revenue FROM employees e LEFT JOIN bills b ON e.employee_id = b.employee_id AND b.deleted = 0 join departments on e.dept_id = departments.dept_id where role_id = 1 GROUP BY e.employee_id, e.fullname ORDER BY total_sales,revenue desc;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<EmployeePerformanceBL> employees = new List<EmployeePerformanceBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string name = dr["fullname"].ToString();
                string username = dr["username"].ToString();
                string department = dr["dept_name"].ToString();
                int performance = Convert.ToInt32(dr["total_sales"]);
                double sales = Convert.ToDouble(dr["revenue"]);
                EmployeePerformanceBL emp = new EmployeePerformanceBL(name, username, department, performance, sales);
                employees.Add(emp);
            }
            return employees;
        }
    }
}
