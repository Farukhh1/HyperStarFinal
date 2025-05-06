using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyperstarManagementSystem.BL
{
    public class EmployeeBL
    {
        public int ID;
        public string Name;
        public string username;
        public string password;
        public int role_id;
        public int dept_id;
        public EmployeeBL(int ID, string Name, string username, string password, int role_id, int dept_id)
        {
            this.ID = ID;
            this.Name = Name;
            this.username = username;
            this.password = password;
            this.role_id = role_id;
            this.dept_id = dept_id;
        }

    }
}
