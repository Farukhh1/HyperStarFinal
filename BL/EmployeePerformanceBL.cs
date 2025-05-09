using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    internal class EmployeePerformanceBL
    {
        public string name {  get; set; }
        public string username { get; set; }
        public string department { get; set; }
        public int performance { get; set; }
        public double sales { get; set; }
        public EmployeePerformanceBL(string name, string username, string department, int performance, double sales)
        {
            this.name = name;
            this.username = username;
            this.department = department;
            this.performance = performance;
            this.sales = sales;
        }
    }
}
