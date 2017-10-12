using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class PrintRemainingBalance : Form
    {
        public PrintRemainingBalance()
        {
            InitializeComponent();
        }

        private void PrintRemainingBalance_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();


            ReportParameter[] allPar = new ReportParameter[3]; // create parameters array
            ReportParameter parSum = new ReportParameter("sum", "195");
            ReportParameter parDiscount = new ReportParameter("discount", "19");
            ReportParameter parTotal = new ReportParameter("total", "176");

            allPar[0] = parSum; //assign parameters to parameter array
           allPar[1] = parDiscount;
            allPar[2] = parTotal;

            reportViewer1.LocalReport.SetParameters(allPar); // set parameter array
            this.reportViewer1.RefreshReport();
        }
    }
}
