using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace SmartSchoolManagementSystem
{
    public partial class admissionform : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        String schoolname, address, schoolemail, phno, cellno ;
        //Int16 Showlogo;
       
        public admissionform()
        {
            InitializeComponent();
            GetCrystalReport();
        }


        public void GetCrystalReport()
        {
         var result =  from a in db.Tblschoolsettings
            from b in db.Tbladmissionprints
            select new {
                FID = b.FID, SchoolName = a.SchoolName,
                FIRSTADDRESS=a.FIRSTADDRESS+" "+a.SECONDADDRESS+"  Email: "+a.FIRSTEMAIL+"  "+a.CONTACTA,
                LOGO = a.LOGO,
            };
            CrystalPrintAdmission cr = new CrystalPrintAdmission();
            cr.SetDataSource(result);
            this.crystalReportViewer1.ReportSource = cr;
           
     
        }


        private void getschooldetails()
        {

            var Getschool =  db.Tblschoolsettings.Select(c => new

   
            {
                Getschool = c.SchoolName,
                Getadrs = c.FIRSTADDRESS,
                Getemail = c.FIRSTEMAIL,
                Getphno = c.CONTACTA,
                Getcell = c.CONTACTB,
                 Getlogo=c.LOGO,
            }).ToList();

            foreach (var GetSchoolInfo in Getschool)
            {
                schoolname = Convert.ToString(GetSchoolInfo.Getschool);
                address = Convert.ToString(GetSchoolInfo.Getadrs);
                schoolemail = Convert.ToString(GetSchoolInfo.Getemail);
                phno = Convert.ToString(GetSchoolInfo.Getphno);
                cellno = Convert.ToString(GetSchoolInfo.Getcell);                             
            }
            //=====================Get form ID

            var GetFormID = db.Tbladmissionprints.Select(b => new

         
            {
                GetFormid = b.FID,
                GetName = b.Name,
                Getclass = b.Section,
                Getsection = b.Section,
                Getcell = b.CellNo,
                
            }).ToList();

            foreach (var Getformid in GetFormID)
            {
                Int32 formID = Convert.ToInt32(Getformid.GetFormid);
                //address = Convert.ToString(GetSchoolInfo.Getadrs);
                //schoolemail = Convert.ToString(GetSchoolInfo.Getemail);
                //phno = Convert.ToString(GetSchoolInfo.Getphno);
                //cellno = Convert.ToString(GetSchoolInfo.Getcell);
                CrystalPrintAdmission cr = new CrystalPrintAdmission();
                TextObject text = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text1"];
                TextObject text1 = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text2"];
                TextObject text2 = (TextObject)cr.ReportDefinition.Sections["Section1"].ReportObjects["Text5"];
                // = Convert.ToString(Image.FromStream(mem));
                text2.Text = Convert.ToString(formID);
                text.Text = Convert.ToString(schoolname);
                text1.Text = Convert.ToString(address + ".Ph No." + phno + ",   " + cellno + "," + schoolemail);
                crystalReportViewer1.ReportSource = cr;
                //CrystalPrintAdmission cr = new CrystalPrintAdmission();

            }


        }
    }
}
