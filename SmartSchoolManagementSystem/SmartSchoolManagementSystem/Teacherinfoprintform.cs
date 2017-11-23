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
    public partial class Teacherinfoprintform : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        int val;
        string sess, Customadd, schooladd = " Address :";
        public Teacherinfoprintform()
        {
            InitializeComponent();
        }

        private void Teacherinfoprintform_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
            try
            {
                List<Tblschoolsetting> schooldata = new List<Tblschoolsetting>();
                schooldata = db.Tblschoolsettings.ToList();

                var Combind = from c in db.Tblschoolsettings

                              select new
                              {
                                  Address = "Address : " + c.FIRSTADDRESS + ". Phone : " + c.CONTACTA + ". Email : " + c.FIRSTEMAIL + ". Website : " + c.WEBSITE

                              };
                foreach (var GetsessionInfo in Combind)
                {
                    //String CompanyName = "Layer Solution Software Development Company LMT";
                    Customadd = GetsessionInfo.Address;



                }




                var Acadmicsession = db.TblacadmicSessions.ToList();
                Tbladmissionprint objcon = new Tbladmissionprint();
                objcon.Name = "abc";
                db.Tbladmissionprints.Add(objcon);
                db.SaveChanges();
                int val = objcon.FID;

                string val2 = val.ToString();
                var GetSession = from c in db.TblacadmicSessions

                                 select new
                                 {
                                     Session = c.AcadmicSession,

                                 };
                foreach (var GetsessionInfo in GetSession)
                {
                    //String CompanyName = "Layer Solution Software Development Company LMT";
                    sess = GetsessionInfo.Session;



                }


                ReportParameter[] parms = new ReportParameter[3];
                parms[0] = new ReportParameter("FID", val2);
                parms[1] = new ReportParameter("AcadmicSession", sess);
                parms[2] = new ReportParameter("Customadd", Customadd);

                this.reportViewer1.LocalReport.SetParameters(parms);
                ReportDataSource datasource = new ReportDataSource("SCHOOLINFO", schooldata);
                reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
