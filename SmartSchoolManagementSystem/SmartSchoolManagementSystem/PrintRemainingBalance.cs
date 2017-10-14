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
           // tsluser.Text = StudentAccount.Studentid
            this.reportViewer1.RefreshReport();


            ReportParameter[] allPar = new ReportParameter[10]; // create parameters array
            ReportParameter a = new ReportParameter("STID", StudentAccount.Studentid);
            ReportParameter b = new ReportParameter("Name", StudentAccount.studentname);
            ReportParameter c = new ReportParameter("Father", StudentAccount.studentfather);
            ReportParameter d = new ReportParameter("Cell", StudentAccount.studentcell);
            ReportParameter f = new ReportParameter("Class", StudentAccount.studentclass);
            ReportParameter g = new ReportParameter("Section", StudentAccount.studensection);
            ReportParameter h = new ReportParameter("Group", StudentAccount.Group);
            ReportParameter j = new ReportParameter("Payable", StudentAccount.payable);
            ReportParameter k = new ReportParameter("Recieved", StudentAccount.recived);
            ReportParameter l = new ReportParameter("blnc", StudentAccount.remaingblnc);



            //assign parameters to parameter array

            allPar[0] = a; 
           allPar[1] = b;
            allPar[2] = c;
            allPar[3] = d;
            allPar[4] = f;
            allPar[5] = g;
            allPar[6] = h;
            allPar[7] = j;
            allPar[8] = k;
            allPar[9] = l;

            reportViewer1.LocalReport.SetParameters(allPar); // set parameter array
            this.reportViewer1.RefreshReport();
        }
    }
}
