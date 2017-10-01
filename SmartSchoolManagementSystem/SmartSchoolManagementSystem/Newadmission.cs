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
        smartschooldbEntities db = new smartschooldbEntities();
        public DataGridViewRow dgvr;
        int SystemID, ClassRollNo, uniqueID, admissionfee, tutionfee, otherfee, result, busfee, classid;
        string imgloc = "";
        public Newadmission()
        {
            InitializeComponent();
            GetSession();
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
                                ProductID = s.ID,
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
            var CurrentSession = from c in db.TblacadmicSessions select new { Session = c.AcadmicSession, };

            foreach (var Sessionvalues in CurrentSession)
            {
                lblSession.Text = Convert.ToString(Sessionvalues.Session);
            }
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
                objcontext.FATHER_NAME = txtfname.Text;
                objcontext.STUDENT_NIC = bform.Text;
                objcontext.FATHER_NIC = maskedTextBox1.Text;
                objcontext.GENDER = cbbgender.Text;
                objcontext.RELIGION = txtriligion.Text;
                objcontext.FATHER_OCCUPATION = txtoccupation.Text;
                objcontext.ADMISSION_DATE = System.DateTime.Now;
                objcontext.DOB = Convert.ToDateTime(txtdob.Text);
                objcontext.PLACE_BIRTH = txtpob.Text;
                objcontext.MONTHLY_INCOM = txtincom.Text;
                objcontext.CAST = txtcast.Text;
                objcontext.CELL_NO = txtcell.Text;
                objcontext.LANDLINE = txtlandlin.Text;
                objcontext.OTHER_NO = txtgcell.Text;
                objcontext.CURRENT_ADDRESS = txtcurrentadress.Text;
                objcontext.PERMANENT_ADDRESS = txtpadress.Text;
                objcontext.PREVIOUS_SCHOOL = txtprevious.Text;
                objcontext.OBTAIN_MARKS = "10";
                objcontext.TOTAL_MARKS = "8";
                objcontext.BLOODGROUP = cbbBloodGroup.Text;
                objcontext.EMAIL_ADDRESS = txtemail.Text;
                objcontext.ADMISSION_STATUS = true;
                objcontext.IMAGE = img;
                objcontext.CREATED_BY = "1";
                objcontext.CREATED_DATE = System.DateTime.Now;
                db.TBLADDMISSIONs.Add(objcontext);
                db.SaveChanges();
                var qaNames = (from a in db.TBLADDMISSIONs select new { a.ID }).ToList();
                foreach (var GetsystemIDVal in qaNames)
                {
                    SystemID = GetsystemIDVal.ID;
                }
                if ((from c in db.TBLSTUDENTENRROLs where c.CLASSNAME == cbbclass.Text && c.SECTION == cbbsection.Text && c.ACADMICSESSION == lblSession.Text select c).Count() > 0)
                {
                    //var GetStudentRollNo = from c in db.TBLSTUDENTENRROLs.OrderByDescending(c => c.ClassId) select new { Getsystem = c.Student_ID, };
                    var GetStudentRollNo = from c in db.TBLSTUDENTENRROLs select new { Getsystem = c.Student_ID, };

                    foreach (var GetstudentRoll in GetStudentRollNo)
                    {
                        int ClassNo = Convert.ToInt16(GetstudentRoll.Getsystem);
                        int val = 1;
                        ClassRollNo = ClassNo + val;
                        //  txtemail.Text = ClassRollNo.ToString();
                    }
                }

                else { ClassRollNo = 1; }
                TBLSTUDENTENRROL objEnRoll = new TBLSTUDENTENRROL();
                {
                    objEnRoll.SystemId = SystemID;
                    objEnRoll.Student_ID = ClassRollNo;
                    objEnRoll.CLASSNAME = cbbclass.Text;
                    objEnRoll.SECTION = cbbsection.Text;
                    objEnRoll.ACADMICSESSION = lblSession.Text;
                    objEnRoll.CREATED_BY = "1";
                    objEnRoll.CREATED_DATE = System.DateTime.Now.ToString();
                    db.TBLSTUDENTENRROLs.Add(objEnRoll);
                    db.SaveChanges();
                }
                var GetStudentRoll = from c in db.TBLSTUDENTENRROLs select new { Getclass = c.ClassId, };
                foreach (var GetstudentRoll in GetStudentRoll)
                {
                    classid = Convert.ToInt16(GetstudentRoll.Getclass);
                }
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
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
            textBox1.Select(textBox1.Text.Length, 1);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            textBox14.Text = textInfo.ToTitleCase(textBox14.Text);
            textBox14.Select(textBox14.Text.Length, 1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            textBox6.Text = textInfo.ToTitleCase(textBox6.Text);
            textBox6.Select(textBox6.Text.Length, 1);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            textBox9.Text = textInfo.ToTitleCase(textBox9.Text);
            textBox9.Select(textBox9.Text.Length, 1);
        }

        private void txtcurrentadress_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtcurrentadress.Text = textInfo.ToTitleCase(txtcurrentadress.Text);
            txtcurrentadress.Select(txtcurrentadress.Text.Length, 1);
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
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            textBox13.Text = textInfo.ToTitleCase(textBox13.Text);
            textBox13.Select(textBox13.Text.Length, 1);
        }

        private void txtpadress_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtpadress.Text = textInfo.ToTitleCase(txtpadress.Text);
            txtpadress.Select(txtpadress.Text.Length, 1);

        }

        private void txtprevious_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtprevious.Text = textInfo.ToTitleCase(txtprevious.Text);
            txtprevious.Select(txtprevious.Text.Length, 1);
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            textBox22.Text = textInfo.ToTitleCase(textBox22.Text);
            textBox22.Select(textBox22.Text.Length, 1);
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
        }

        private void cbbclass_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var qaNames = (from a in db.Tblclasssections
                           where a.Class == cbbclass.SelectedItem.ToString()
                           select new { a.ID, Names = a.Section, }).ToList();
            cbbsection.DataSource = qaNames.ToList();
            cbbsection.DisplayMember = "Names";
            cbbsection.ValueMember = "ID";
        }

        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {
            var qaNames = (from a in db.Tblclasssections
                           where a.Class == cbbclass.SelectedItem.ToString()
                           select new { a.ID, Names = a.Section, }).ToList();
            cbbsection.DataSource = qaNames.ToList();
            cbbsection.DisplayMember = "Names";
            cbbsection.ValueMember = "ID";
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
