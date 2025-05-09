using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using HyperstarManagementSystem.BL;

namespace HyperstarManagementSystem.DL
{
    internal class SupplierDL
    {
        public static List<SupplierBL> GetAll()
        {
            string qry = "select * from suppliers where deleted = 0";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<SupplierBL> suppliers = new List<SupplierBL>();
            foreach (DataRow dr in dt.Rows)
            {
                int supplierID = Convert.ToInt32(dr["supplier_id"]);
                string supplierName = dr["name"].ToString();
                string city = dr["city"].ToString();
                string contact = dr["contact"].ToString();
                SupplierBL s = new SupplierBL(supplierID, supplierName, city, contact);
                suppliers.Add(s);
            }
            return suppliers;
        }
        public static List<string> GetAllNames()
        {
            string qry = "select name from suppliers where deleted = 0";
            DataTable dt = DataBaseHelper.GetTable(qry);
            List<string> suppliers = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                string supplierName = dr["name"].ToString();
                suppliers.Add(supplierName);
            }
            return suppliers;
        }
        public static int GetID(string name)
        {
            string qry = $"select supplier_id from suppliers where name = '{name}' and deleted = 0";
            DataTable dt = DataBaseHelper.GetTable(qry);

            return Convert.ToInt32(dt.Rows[0]["supplier_id"]);

        }
        public static void Add(SupplierBL sp)
        {
            string qry = $"insert into suppliers(name, city, contact) values ('{sp.SupplierName}', '{sp.City}', '{sp.Contact}')";
            DataBaseHelper.ExecuteDML(qry);
        }
        public static void Delete(int id)
        {
            string qry = $"update suppliers set deleted = 1 where supplier_id = {id}";
            DataBaseHelper.ExecuteDML(qry);
        }
        public static void Update(SupplierBL sp)
        {
            string qry = $"update suppliers set name = '{sp.SupplierName}', city = '{sp.City}', contact = '{sp.Contact}' where supplier_id = {sp.SupplierID}";
            DataBaseHelper.ExecuteDML(qry);
        }
    }
}
