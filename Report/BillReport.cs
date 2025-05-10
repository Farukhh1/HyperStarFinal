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
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace HyperstarManagementSystem.Report
{
    public partial class BillReport : UserControl
    {
        public BillReport()
        {
            InitializeComponent();
        }

        private void BillReport_Load(object sender, EventArgs e)
        {
            ShowBillReport(7);
            reportViewer1.RefreshReport();
        }
        public void ShowBillReport(int billId)
        {
            var reportData = BillsDL.GetBillReport(billId);  // Get report data

            // 1. Data source for bill items (table)
            ReportDataSource rds = new ReportDataSource("DataSet1", reportData.Items);

            // 2. Parameters for header/footer
            ReportParameter[] parameters = new ReportParameter[]
            {
                new ReportParameter("BillID", reportData.BillID.ToString()),
                new ReportParameter("BillDate", reportData.BillDate.ToString("yyyy-MM-dd")),
                new ReportParameter("CustomerName", reportData.CustomerName),
                new ReportParameter("EmployeeName", reportData.EmployeeName),
                new ReportParameter("TotalAmount", reportData.TotalAmount.ToString("F2")),
                new ReportParameter("CashReceived", reportData.CashReceived.ToString("F2")),
                new ReportParameter("Change", reportData.Change.ToString("F2"))
            };

            // 3. Bind everything to *this* reportViewer in your UserControl
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "F:\\DB\\Final_Project\\HyperStarFinal\\Report\\BillReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }


    }
}
