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
            string qry = "SELECT dept_name as DepartmentName,Discount,descrip as description FROM departments;";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<DepartmentBL> departments = new List<DepartmentBL>();
            foreach (DataRow dr in dt.Rows)
            {
                string departmentName = (dr["DepartmentName"]).ToString();
                double discount = Convert.ToDouble(dr["Discount"]);
                string departmentDescription = (dr["description"]).ToString();
                DepartmentBL d = new DepartmentBL(departmentName, discount, departmentDescription);
                departments.Add(d);
            }
            return departments;
        }
    }
}
