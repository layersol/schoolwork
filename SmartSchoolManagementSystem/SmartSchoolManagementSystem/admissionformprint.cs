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
    public partial class admissionformprint : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        int val;
        public admissionformprint()
        {
            InitializeComponent();
        }

        private void admissionformprint_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            try
            {
                List<Tblschoolsetting> schooldata = new List<Tblschoolsetting>();
                schooldata = db.Tblschoolsettings.ToList();

                Tbladmissionprint objcon = new Tbladmissionprint();
                objcon.Name = "abc";
                db.Tbladmissionprints.Add(objcon);
                db.SaveChanges();
                int val = objcon.FID;

                string val2 = val.ToString();

            ReportParameter[] parms = new ReportParameter[1];
            parms[0] = new ReportParameter("FID", val2);

            this.reportViewer1.LocalReport.SetParameters(parms);
                ReportDataSource datasource = new ReportDataSource("SCHOOLINFO", schooldata);
                reportViewer1.LocalReport.DataSources.Add(datasource);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }



            //assign parameters to parameter array

            //allPar[0] = a;

            //reportViewer1.LocalReport.SetParameters(allPar); // set parameter array
            //this.reportViewer1.RefreshReport();
            //db.Tbladmissionprints .Last(0);
            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource datasource = new ReportDataSource("ADMISSIONFORMID", Forprint);       
            //reportViewer1.LocalReport.DataSources.Add(datasource);          
            //this.reportViewer1.RefreshReport();
            //try
            //{
            //    Tbladmissionprint objcon = new Tbladmissionprint();
            //    objcon.Name = "abc";
            //        db.Tbladmissionprints.Add(objcon);
            //    db.SaveChanges();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
