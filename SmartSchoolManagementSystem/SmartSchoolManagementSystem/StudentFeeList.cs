using Microsoft.Reporting.WinForms;
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

namespace SmartSchoolManagementSystem
{
    public partial class StudentFeeList : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();

        public StudentFeeList()
        {
            InitializeComponent();
        }       
        private void getschoolinfo()
        {
            var reportQuery = (
               from a in db.Tblschoolsettings
              
               select new
               {
                   a.SchoolName,
                   a.LOGO
               }).ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("SchoolIformation", reportQuery);
            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
        private void StudentFeeList_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            var reportQuery = (
                from a in db.TBLADDMISSIONs
                join c in db.TBLSTUDENTENRROLs on a.SID equals c.SystemId
                join s in db.Tblclasssections on c.CID equals s.ID
                join g in db.TBLSTUDENTFEEDETAILS on c.Student_ID equals g.SYSID               
                where a.SID == 6
                select new
                {
                    g.FID,
                    a.SID,
                    g.SFID,
                    c.Student_ID,
                    a.FATHER_NAME,
                    a.S_CELL_NO,
                    s.Class,
                    s.Section,
                    s.Group,
                    a.STUDENT_NAME,
                    g.TUITION_FEE,
                    g.LATE_FEE,
                    g.AMOUNT_PAYABLE,
                    g.AMOUNT_PAID,
                    g.BALANCE,
                    g.FEE_DATE,
                    a.IMAGE
                }).ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("STUDENTFEELIST", reportQuery);

            reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();

           

        }
    }
}
