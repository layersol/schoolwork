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
    public partial class studentidcard : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public studentidcard()
        {
            InitializeComponent();
        }

        private void studentidcard_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            List<Tblschoolsetting> schooldata = new List<Tblschoolsetting>();
            schooldata = db.Tblschoolsettings.ToList();

            var reportQuery = (

                 from s in db.TBLSTUDENTENRROLs
                 join g in db.Tblclasssections on s.CID equals g.ID
                 join a in db.TBLADDMISSIONs on s.SystemId equals a.SID
                 join d in db.Tblschoolsettings on 1 equals d.ID
            where s.CID==StudentIdCardForm.classidget
                 select new
            {
             
              a.STUDENT_NAME,
              s.Student_ID,
              g.Class,
              g.Section,
              a.S_CELL_NO,
              a.IMAGE,
              d.SchoolName,
              d.LOGO
            }).ToList();
            reportViewer1.LocalReport.DataSources.Clear();
            ReportDataSource datasource = new ReportDataSource("PrintStudentIDCard", reportQuery);
            //ReportDataSource datasource2 = new ReportDataSource("SCHOOLINFO", schooldata);

            reportViewer1.LocalReport.DataSources.Add(datasource);
          //  reportViewer1.LocalReport.DataSources.Add(datasource2);
            this.reportViewer1.RefreshReport();

        }
    }
}
