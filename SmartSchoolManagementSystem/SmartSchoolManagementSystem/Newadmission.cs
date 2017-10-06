using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class Newadmission : Form
    {
        smartschooldbEntities1 db = new smartschooldbEntities1();
        public DataGridViewRow dgvr;
        int SystemID, ClassRollNo, uniqueID=0, admissionfee=0,discount=0, tutionfee=0, otherfee=0, result=0, busfee=0, classid=0;
        string imgloc = "";
        public Newadmission()
        {
            InitializeComponent();
            GetSession();
            Getdropdown();
        }

         private void Getdropdown()
        {
            var Getclass = (from a in db.Tblclasses
                           //where a.Class == cbbclass.SelectedItem.ToString()
                           select new { a.ID, Names = a.CLASSNAME }).ToList();
            cbbclass.DataSource = Getclass;
            cbbclass.DisplayMember = "Names";
            cbbclass.ValueMember = "ID";
            var Getgroup = (from a in db.Tblclasssections
                                //where a.Class == cbbclass.SelectedItem.ToString()
                            select new { a.ID, Names = a.Group, }).ToList();

            cbbgroup.DataSource = Getgroup.ToList();
            cbbgroup.DisplayMember = "Names";
            cbbgroup.ValueMember = "ID";
        }
        private void Getcurrentstudent()
        {
             var val2 = (from u in db.TBLADDMISSIONs where u.CURRENTSESSION == "2017-2018" select u).Count() > 0;
             if (val2 != false)
            {

                var query = from s in db.TBLADDMISSIONs
                            where s.CURRENTSESSION == "2017-2018"
                            select new
                            {
                                ProductID = s.SID,
                                Stock = s.STUDENT_NAME,
                            };
                dvgstudent.DataSource = query.ToList();

            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void GetSession()
        {
            //var CurrentSession = from c in db.TblacadmicSessions select new { Session = c.AcadmicSession, };

            //foreach (var Sessionvalues in CurrentSession)
            //{
            //    lblSession.Text = Convert.ToString(Sessionvalues.Session);
            //}
        }
        private void btnup_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    imgpicturebox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btntake_Click(object sender, EventArgs e)
        {

        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            txtform.Enabled = true;
            btnsearch.Enabled = true;
            txtcreationdate.Text = System.DateTime.Now.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgloc, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                byte[] image = new byte[fs.Length];
                fs.Read(image, 0, Convert.ToInt32(fs.Length));
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                // testimage ins = new testimage();
                // ins.Photo = img;


                TBLADDMISSION objcontext = new TBLADDMISSION();
                objcontext.ADMISSION_FORM = txtform.Text;




                objcontext.STUDENT_NAME = txtstudentname.Text;
                objcontext.STUDENT_DOB = Convert.ToDateTime(txtdob.Text);
                objcontext.PLACE_BIRTH = txtpob.Text;
                objcontext.STUDENT_NIC = bform.Text;
                objcontext.GENDER = cbbgender.Text;
                objcontext.RELIGION = txtriligion.Text;
                objcontext.S_CELL_NO = txtcell.Text;
                objcontext.STUDENT_EMAIL_ADDRESS=

                objcontext.FATHER_NAME = txtfname.Text;
                objcontext.STUDENT_NIC = bform.Text;
                objcontext.FATHER_NIC = txtcnic.Text;
               
              
                objcontext.FATHER_OCCUPATION = txtoccupation.Text;
                objcontext.ADMISSION_DATE = System.DateTime.Now;
                
                
                objcontext.MONTHLY_INCOM = txtincom.Text;
                objcontext.FATHER_CAST = txtcast.Text;
               
                objcontext.FATHER_CELL_NO = txtsmail.Text;
                objcontext.HOME_TEL = txtfcell.Text;
                objcontext.HOME_ADDRESS = txthomeadress.Text;
                objcontext.BUSINESS_ADDRESS = txtofficeadress.Text;
               // objcontext.PREVIOUS_SCHOOL = txtprevious.Text;
                objcontext.OBTAIN_MARKS1 = "10";
                objcontext.TOTAL_MARKS1 = "8";
                objcontext.BLOODGROUP = cbbBloodGroup.Text;
              //  objcontext.EMAIL_ADDRESS = txtemail.Text;
                objcontext.ADMISSION_STATUS = true;
                objcontext.IMAGE = img;
                objcontext.CREATED_BY = "1";
                objcontext.CREATED_DATE = System.DateTime.Now;
                db.TBLADDMISSIONs.Add(objcontext);
                db.SaveChanges();

                //var qaNames = (from a in db.TBLADDMISSIONs select new { a.SID }).ToList();
                //foreach (var GetsystemIDVal in qaNames)
                //{
                //    SystemID = GetsystemIDVal.SID;
                //}
                //if ((from c in db.TBLSTUDENTENRROLs where c.CLASSNAME == cbbclass.Text && c.SECTION == cbbsection.Text && c.ACADMICSESSION == lblSession.Text select c).Count() > 0)
                //{
                //    //var GetStudentRollNo = from c in db.TBLSTUDENTENRROLs.OrderByDescending(c => c.ClassId) select new { Getsystem = c.Student_ID, };
                //    var GetStudentRollNo = from c in db.TBLSTUDENTENRROLs select new { Getsystem = c.Student_ID, };

                //    foreach (var GetstudentRoll in GetStudentRollNo)
                //    {
                //        int ClassNo = Convert.ToInt16(GetstudentRoll.Getsystem);
                //        int val = 1;
                //        ClassRollNo = ClassNo + val;
                //        //  txtemail.Text = ClassRollNo.ToString();
                //    }
                //}

                //else { ClassRollNo = 1; }
                //TBLSTUDENTENRROL objEnRoll = new TBLSTUDENTENRROL();
                //{
                //    objEnRoll.SystemId = SystemID;
                //    objEnRoll.Student_ID = ClassRollNo;
                //    objEnRoll.CLASSNAME = cbbclass.Text;
                //    objEnRoll.SECTION = cbbsection.Text;
                //    objEnRoll.ACADMICSESSION = lblSession.Text;
                //    objEnRoll.CREATED_BY = "1";
                //    objEnRoll.CREATED_DATE = System.DateTime.Now.ToString();
                //    db.TBLSTUDENTENRROLs.Add(objEnRoll);
                //    db.SaveChanges();
                //}
                //var GetStudentRoll = from c in db.TBLSTUDENTENRROLs select new { Getclass = c.ClassId, };
                //foreach (var GetstudentRoll in GetStudentRoll)
                //{
                //    classid = Convert.ToInt16(GetstudentRoll.Getclass);
                //}
                //TBLACCOUNT objfee = new TBLACCOUNT();
                //{
                //    objfee.SystemId = SystemID;
                //    objfee.CLASSID = classid;
                //    objfee.SDTID = ClassRollNo;
                //    // objfee.ADMISSION_FEE = txtadmissionfee.Text;
                //    objfee.TUTION_FEE = txttution.Text;
                //    objfee.TOTAL_AMOUNT = txttotal.Text;
                //    objfee.Arrears = "0";
                //    objfee.OTHER_FEE = txtother.Text;
                //    objfee.Balance = "0";
                //    objfee.FEE_DATE = Convert.ToDateTime(txtadmissiondate.Text);
                //    db.TBLACCOUNTs.Add(objfee);
                //    db.SaveChanges();
                //    MessageBox.Show("Student Has Been Enrolled Successfully");
                //}
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            MessageBox.Show("Student has been Successfully add.!");
        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int sid = Convert.ToInt16(txtform.Text);
            var q = (from a in db.Tbladmissionprints
                     where a.FID ==sid
                     select a).SingleOrDefault();
            //PID = q.ID;
            txtstudentname.Text = q.Name;
            txtcell.Text = q.CellNo;
            cbbclass.Text = q.Class;



            txtupdatedby.Text = cbbclass.Text;
           

            // cbbgroup.Text = q.Section;

            // imgpicturebox.ImageLocation =Convert.ToString(q.LOGO);
            //var qaNames = (from a in db.Tblclasses
            //                   // where a.CLASS == cbbclass.Text
            //               select new { a.ID, Names = a.CLASSNAME, }).ToList();
            //cbbclass.DataSource = q.Class;
            //cbbclass.DisplayMember = "Names";
            //cbbclass.ValueMember = "ID";

        }

        private void cbbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var qaNames = (from a in db.Tblclasses
            //                    where a.CLASS == cbbclass.Text
            //               select new { a.ID, Names = a.CLASSNAME, }).ToList();
            //cbbclass.DataSource = q.Class;
            //cbbclass.DisplayMember = "Names";
            //cbbclass.ValueMember = "ID";
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtfname.Text = textInfo.ToTitleCase(txtfname.Text);
            txtfname.Select(txtfname.Text.Length, 1);
        }

        private void txtoccupation_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtoccupation.Text = textInfo.ToTitleCase(txtoccupation.Text);
            txtoccupation.Select(txtoccupation.Text.Length, 1);
        }

        private void txtpob_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtpob.Text = textInfo.ToTitleCase(txtpob.Text);
            txtpob.Select(txtpob.Text.Length, 1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtadminssion1.Text = textInfo.ToTitleCase(txtadminssion1.Text);
            txtadminssion1.Select(txtadminssion1.Text.Length, 1);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtadmission2.Text = textInfo.ToTitleCase(txtadmission2.Text);
            txtadmission2.Select(txtadmission2.Text.Length, 1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txttmark2.Text = textInfo.ToTitleCase(txttmark2.Text);
            txttmark2.Select(txttmark2.Text.Length, 1);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtobtain2.Text = textInfo.ToTitleCase(txtobtain2.Text);
            txtobtain2.Select(txtobtain2.Text.Length, 1);
        }

        private void txtcurrentadress_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txthomeadress.Text = textInfo.ToTitleCase(txthomeadress.Text);
            txthomeadress.Select(txthomeadress.Text.Length, 1);
        }

        private void txtcast_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtcast.Text = textInfo.ToTitleCase(txtcast.Text);
            txtcast.Select(txtcast.Text.Length, 1);
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            //CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            //TextInfo textInfo = cI.TextInfo;
            //textBox13.Text = textInfo.ToTitleCase(textBox13.Text);
            //textBox13.Select(textBox13.Text.Length, 1);
        }

        private void txtpadress_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtofficeadress.Text = textInfo.ToTitleCase(txtofficeadress.Text);
            txtofficeadress.Select(txtofficeadress.Text.Length, 1);

        }

        private void txtprevious_TextChanged(object sender, EventArgs e)
        {
            //CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            //TextInfo textInfo = cI.TextInfo;
            //txtprevious.Text = textInfo.ToTitleCase(txtprevious.Text);
            //txtprevious.Select(txtprevious.Text.Length, 1);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtschoolname1.Text = textInfo.ToTitleCase(txtschoolname1.Text);
            txtschoolname1.Select(txtschoolname1.Text.Length, 1);
        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            if (txtform.Text !="")
            {
                int fid= Convert.ToInt16(txtform.Text);
                var q = (from a in db.Tbladmissionprints
                         where a.FID == fid
                         select a).SingleOrDefault();
                // PID = q.FID;
                txtstudentname.Text = q.Name;

                cbbclass.Text = q.Class;
                cbbgroup.Text = q.Section;
                txtcell.Text = q.CellNo;
            }
            else { MessageBox.Show("Please Add Correct Form No."); }


            var Ssection = (from b in db.Tblclasssections
                                // from b in db.TblSections
                            where b.Class == cbbclass.Text && b.Group== cbbgroup.Text
                            select new
                            {
                                b.ID,
                                Section = b.Section
                            });
           
            {
                cbbsection.DataSource = Ssection.ToList();
                cbbsection.DisplayMember = "Section";
                cbbsection.ValueMember = "ID";
            }
           
        }

        private void cbbclass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //var qaNames = (from a in db.Tblclasssections
            //               where a.Class == cbbclass.SelectedItem.ToString()
            //               select new { a.ID, Names = a.Section, }).ToList();
            //cbbsection.DataSource = qaNames.ToList();
            //cbbsection.DisplayMember = "Names";
            //cbbsection.ValueMember = "ID";
        }

        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {
            var Getsection= (from a in db.Tblclasssections
                           where a.Class == cbbclass.Text
                           select new { a.ID, Names = a.Section, }).ToList();
            cbbsection.DataSource = Getsection.ToList();
            cbbsection.DisplayMember = "Names";
            cbbsection.ValueMember = "ID";
        }
        private void calculate()
        {
            //txtotherfee.Text = Convert.ToString(otherfee);
            //txtotherfee.Text = Convert.ToString(discount);
            
            otherfee = Convert.ToInt32(txtotherfee.Text);
            admissionfee = Convert.ToInt32(txtadfee.Text);
            tutionfee = Convert.ToInt32(txttutionfee.Text);


            txttotal.Text = Convert.ToString(admissionfee + tutionfee + otherfee);
        }

        private void txtotherfee_TextChanged(object sender, EventArgs e)
        {
           //  calculate();
           // txttotal.Text = txtotherfee.Text;
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {
            //calculate();
        }

        private void txtotherfee_Enter(object sender, EventArgs e)
        {
          
        }

        private void txtotherfee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculate();
            }
        }

        private void Discount()
        {
            int totalval = Convert.ToInt32(txttotal.Text);
            int discount = Convert.ToInt32(txtdiscount.Text);
            int result= -((discount / 100) * totalval) + totalval;
            txttotal.Text = Convert.ToString(result);
        }

        private void txtdiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Discount();
            }
        }

        private void cbbmedium_SelectedValueChanged(object sender, EventArgs e)
        {
            var GetAccount = from c in db.Tblclasssections where c.Class==cbbclass.Text && c.Section==cbbsection.Text && c.Group==cbbgroup.Text select new { Adfee = c.admissionfee,Tution=c.Fee, };

            foreach (var Sessionvalues in GetAccount)
            {
                txtadfee.Text = Convert.ToString(Sessionvalues.Adfee);
                txttutionfee.Text = Convert.ToString(Sessionvalues.Tution);
                float a, b;
                a =float.Parse(txtadfee.Text);
                b = float.Parse(txtadfee.Text);
            }
           // calculate();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        private void btnview_Click(object sender, EventArgs e)
        {

        }

        private void btnprint_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnback_Click(object sender, EventArgs e)
        {

        }

        private void btnnext_Click(object sender, EventArgs e)
        {

        }

        private void Newadmission_Load(object sender, EventArgs e)
        {

           
            txtcreatedby.Text = Login.SetValueForText;
            txtcreationdate.Text = Convert.ToString(System.DateTime.Now);
            //    txtform.Text = dgvr.Cells[0].Value.ToString();
            //    txtstudentname.Text = dgvr.Cells[1].Value.ToString();
            //txtcell.Text = dgvr.Cells[2].Value.ToString();
            //cbbclass.Text = dgvr.Cells[3].Value.ToString();
            //cbbsection.Text = dgvr.Cells[4].Value.ToString();

        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtstudentname.Text = textInfo.ToTitleCase(txtstudentname.Text);
            txtstudentname.Select(txtstudentname.Text.Length, 1);
        }
    }
}
