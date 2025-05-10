using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class DepartmentDL
    {
        public static List<DepartmentBL> GetDepartments()
        {
            string qry = "SELECT d.dept_name AS DepartmentName, d.discount AS Discount, d.descrip AS Description,COALESCE(SUM(bd.total_price), 0) AS Total_Revenue FROM departments d LEFT JOIN products p ON d.dept_id = p.dept_id LEFT JOIN billdetails bd ON p.product_code = bd.product_code LEFT JOIN bills b ON bd.bill_id = b.bill_id AND b.deleted = 0 GROUP BY d.dept_id, d.dept_name, d.discount, d.descrip ORDER BY Total_Revenue DESC;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<DepartmentBL> departments = new List<DepartmentBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string departmentName = (dr["DepartmentName"]).ToString();
                double discount = Convert.ToDouble(dr["Discount"]);
                string departmentDescription = (dr["Description"]).ToString();
                double totalRevenue = Convert.ToDouble(dr["Total_Revenue"]);
                DepartmentBL d = new DepartmentBL(departmentName, discount, departmentDescription,totalRevenue);
                departments.Add(d);
            }
            return departments;
        }
    }
}
