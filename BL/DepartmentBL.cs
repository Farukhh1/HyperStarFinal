using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class DepartmentBL
    {
        public string DepartmentName { get; set; }
        public double Discount { get; set; }
        public string DepartmentDescription { get; set; }
        public DepartmentBL(string DepartmentName,double Discount, string DepartmentDescription)
        {
            this.Discount = Discount;
            this.DepartmentName = DepartmentName;
            this.DepartmentDescription = DepartmentDescription;
        }
    }
}
