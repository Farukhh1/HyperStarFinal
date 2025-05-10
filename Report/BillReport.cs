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
        private int billId;
        public BillReport(int billID)
        {
            InitializeComponent();
            this.billId = billID;
        }

        private void BillReport_Load(object sender, EventArgs e)
        {
            ShowBillReport();
            reportViewer1.RefreshReport();
        }
        public void ShowBillReport()
        {
            var reportData = BillsDL.GetBillReport(billId);
            ReportDataSource rds = new ReportDataSource("DataSet1", reportData.Items);
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
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            reportViewer1.LocalReport.ReportPath = "C:\\Users\\Admin\\Documents\\GitHub\\DBSF013\\HyperStarManagementSystem\\Report\\BillReport.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.SetParameters(parameters);
            reportViewer1.RefreshReport();
        }


    }
}
