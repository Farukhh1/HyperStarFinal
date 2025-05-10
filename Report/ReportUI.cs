using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HyperstarManagementSystem.DL;
using Microsoft.Reporting.WinForms;

namespace HyperstarManagementSystem.Reports
{
    public partial class ReportUI : UserControl
    {
        public ReportUI()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Active Products")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\ProductReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = ProductDL.GetAllProducts();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if(comboBox1.Text == "InActive Products")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\InactiveProducts.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = ProductDL.GetAllInactiveProducts();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (comboBox1.Text == "Departments")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\DepartmentReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = DepartmentDL.GetDepartments();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (comboBox1.Text == "Customers")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\CustomerReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = CustomerReportDL.GetCustomers();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (comboBox1.Text == "Product Sale")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\ALLProductSoldReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = ProductSaleDL.GetProductSales();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (comboBox1.Text == "Top10 Sold Products")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\ALLProductSoldReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = ProductSaleDL.GetProductSalesTop10();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            else if (comboBox1.Text == "Employee Performance")
            {
                string reportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\EmployeePerformanceReport.rdlc";
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = reportPath;
                var data = EmployeePerformanceDL.GetEmployeePerformance();
                ReportDataSource rds = new ReportDataSource("DataSet1", data);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);
            }
            reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReportUI_Load(object sender, EventArgs e)
        {

        }
    }
}
