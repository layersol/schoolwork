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
        int  ClassRollNo, admissionfee=0, tutionfee=0, otherfee=0, classid;
        string imgloc = "",dgv;
        public Newadmission()
        {
            InitializeComponent();
            GetSession();
            Getdropdown();
        }
        private byte[] convertfiletobyte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
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
            try
            {
                var val2 = (from u in db.TBLADDMISSIONs where u.CURRENTSESSION == lblSession.Text select u).Count() > 0;
                if (val2 != false)
                {

                    var query = from s in db.TBLADDMISSIONs
                                where s.CURRENTSESSION == lblSession.Text
                                select new
                                {
                                    NO = s.SID,
                                    StudentName = s.STUDENT_NAME,
                                };
                    dvgstudent.DataSource = query.ToList();

                }
                else
                {
                    MessageBox.Show("No Record Found at this time please click ok");
                }
            }
            catch( Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void GetSession()
        {
            var CurrentSession = from c in db.TblacadmicSessions select new { Session = c.AcadmicSession, };

            foreach (var Sessionvalues in CurrentSession)
            {
                lblSession.Text = Convert.ToString(Sessionvalues.Session);
            }

            Getcurrentstudent();

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
                if (cbbclass.Text != "" && cbbsection.Text != "" && cbbgroup.Text != "")
                {
                    var q = (from a in db.Tblclasssections
                             where a.Class == cbbclass.Text && a.Section == cbbsection.Text && a.Group == cbbgroup.Text
                             select a).SingleOrDefault();
                    int Classid = q.ID;
                    TBLADDMISSION objcontext = new TBLADDMISSION();
                    objcontext.ADMISSION_FORM = txtform.Text;
                    objcontext.STUDENT_NAME = txtstudentname.Text;
                    objcontext.STUDENT_DOB = Convert.ToDateTime(txtdob.Text);
                    objcontext.PLACE_BIRTH = txtpob.Text;
                    objcontext.STUDENT_NIC = bform.Text;
                    objcontext.GENDER = cbbgender.Text;
                    objcontext.RELIGION = txtriligion.Text;
                    objcontext.S_CELL_NO = txtcell.Text;
                    objcontext.STUDENT_EMAIL_ADDRESS = txtsmail.Text;
                    objcontext.ADMISSION_STATUS = ckbstatus.Checked;
                    objcontext.HOME_ADDRESS = txthomeadress.Text;
                    objcontext.BLOODGROUP = cbbBloodGroup.Text;
                    objcontext.IMAGE = convertfiletobyte(this.imgpicturebox.ImageLocation);
                    objcontext.FATHER_NAME = txtfname.Text;
                    objcontext.FATHER_NIC = txtcnic.Text;
                    objcontext.FATHER_CELL_NO = txtfcell.Text;
                    objcontext.FATHER_OCCUPATION = txtoccupation.Text;
                    objcontext.MONTHLY_INCOM = txtincom.Text;
                    objcontext.OFFICE_LANDLINE = txtofficetel.Text;
                    objcontext.FATHER_CAST = txtcast.Text;
                    objcontext.BUSINESS_ADDRESS = txtofficeadress.Text;
                    objcontext.CURRENTSESSION = lblSession.Text;   ///     check this again
                    objcontext.G_NAME = txtgname.Text;
                    objcontext.G_CNIC = txtgcnic.Text;
                    objcontext.G_CELL = txtgcell.Text;
                    objcontext.G_OCCUPATION = txtgoccupatio.Text;
                    objcontext.G_MONTHLY_INCOM = txtgmonthincom.Text;
                    objcontext.G_CELL_NO = txtgcell.Text;
                    objcontext.G_BUSINESS_ADDRESS = txtgoffice.Text;
                    objcontext.EDUCATION1 = cbbedu1.Text;
                    objcontext.EDUCATION2 = cbbedu2.Text;
                    objcontext.ADMISSIONNO1 = txtadminssion1.Text;
                    objcontext.ADMISSIONNO2 = txtadmission2.Text;
                    objcontext.YEAR1 = txtpassyear.Text;
                    objcontext.YEAR2 = txtpasyear2.Text;
                    objcontext.BOARD_INSTITUTION1 = txtboard1.Text;
                    objcontext.BOARD_INSTITUTION2 = txtboard2.Text;
                    objcontext.BOARD_INSTITUTION2 = txtboard2.Text;
                    objcontext.GRADE1 = cbbgrad1.Text;
                    objcontext.GRADE2 = cbbgrad2.Text;
                    objcontext.TOTAL_MARKS1 = txttmark.Text;
                    objcontext.TOTAL_MARKS2 = txttmark2.Text;
                    objcontext.OBTAIN_MARKS1 = txtobtain1.Text;
                    objcontext.OBTAIN_MARKS2 = txtobtain2.Text;
                    objcontext.PERCENTAGE1 = txtpercent1.Text;
                    objcontext.PERCENTAGE2 = txtpercent2.Text;
                    objcontext.STUDENTNAME1 = txtstname1.Text;
                    objcontext.STUDENTNAME1 = txtstname2.Text;
                    objcontext.CLAS1 = txtinwhich1.Text;
                    objcontext.CLAS2 = txtinwhich2.Text;
                    objcontext.SCHOOLNAME1 = txtschoolname1.Text;
                    objcontext.SCHOOLNAME2 = txtschool2.Text;
                    objcontext.ADMISSION_DATE = System.DateTime.Now;
                    objcontext.CREATED_BY = txtcreatedby.Text;
                    objcontext.CREATED_DATE = System.DateTime.Now;
                    db.TBLADDMISSIONs.Add(objcontext);
                    db.SaveChanges();
                    int SystemID = objcontext.SID;


                    TBLSTUDENTENRROL objEnRoll = new TBLSTUDENTENRROL();
                    {
                        objEnRoll.SystemId = SystemID;
                        objEnRoll.Student_ID = SystemID;
                        objEnRoll.CID = Classid;
                        objEnRoll.ACADMICSESSION = lblSession.Text;
                        db.TBLSTUDENTENRROLs.Add(objEnRoll);
                        db.SaveChanges();
                       // classid = objEnRoll.ClassId;
                    }
                    TBLSTUDENTFEEDETAIL objfee = new TBLSTUDENTFEEDETAIL();
                    {
                        objfee.SYSID = SystemID;
                        objfee.FID = Classid;
                        objfee.ADMISSION_FEE = Convert.ToDecimal(txtadfee.Text);
                        objfee.TUITION_FEE = Convert.ToDecimal(txttutionfee.Text);
                        objfee.OTHER_FEE = Convert.ToDecimal(txtotherfee.Text);
                        objfee.DISCOUNT = Convert.ToDecimal(txtdiscount.Text);
                        objfee.TOTAL_FEE = Convert.ToDecimal(txtpayable.Text);
                        objfee.AMOUNT_PAYABLE = Convert.ToDecimal(txttotal.Text);
                        objfee.AMOUNT_PAID = Convert.ToDecimal(txtpaid.Text);
                        objfee.FEE_DATE = System.DateTime.Today;
                        objfee.BUS_FEE = Convert.ToDecimal(txtpaid.Text);
                        db.TBLSTUDENTFEEDETAILS.Add(objfee);
                        db.SaveChanges();
                    } }
                else { MessageBox.Show("Select Class"); }

                    //  MessageBox.Show("Student Has Been Enrolled Successfully");
                
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

            MessageBox.Show("Student has been Successfully add.!");
            Getcurrentstudent();
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
            //if (txtform.Text !="")
            //{
            //    int fid= Convert.ToInt16(txtform.Text);
            //    var q = (from a in db.Tbladmissionprints
            //             where a.FID == fid
            //             select a).SingleOrDefault();
            //    // PID = q.FID;
            //    txtstudentname.Text = q.Name;

            //    cbbclass.Text = q.Class;
            //    cbbgroup.Text = q.Section;
            //    txtcell.Text = q.CellNo;
            //}
            //else { MessageBox.Show("Please Add Correct Form No."); }


            //var Ssection = (from b in db.Tblclasssections
            //                    // from b in db.TblSections
            //                where b.Class == cbbclass.Text && b.Group== cbbgroup.Text
            //                select new
            //                {
            //                    b.ID,
            //                    Section = b.Section
            //                });
           
            //{
            //    cbbsection.DataSource = Ssection.ToList();
            //    cbbsection.DisplayMember = "Section";
            //    cbbsection.ValueMember = "ID";
            //}
           
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


            txtpayable.Text = Convert.ToString(admissionfee + tutionfee + otherfee);
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
            //int totalval = Convert.ToInt32(txttotal.Text);
            otherfee = Convert.ToInt32(txtotherfee.Text);
            admissionfee = Convert.ToInt32(txtadfee.Text);
            tutionfee = Convert.ToInt32(txttutionfee.Text);


            decimal reslt = Convert.ToDecimal(admissionfee + tutionfee + otherfee);

            decimal discount = Convert.ToDecimal(txtdiscount.Text);
            decimal result= -((discount / 100) * reslt) + reslt;
            txtpayable.Text = Convert.ToString(result);
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
            if (cbbclass.Text != "" && cbbsection.Text != "" && cbbgroup.Text != "" )
            {
                try
                {
                    var GetAccount = from c in db.TBLFEEMASTERs
                                     where c.STU_Class == classid
                                     select new { c.ADMISSION_FEE,c.TUITION_FEE,c.TUITION_FEE_PERCENT,c };

                    foreach (var Sessionvalues in GetAccount)
                    {
                        txtadfee.Text = Convert.ToString(Sessionvalues.ADMISSION_FEE);
                        txttutionfee.Text = Convert.ToString(Sessionvalues.TUITION_FEE);
                        txtdiscount.Text = Convert.ToString(Sessionvalues.TUITION_FEE_PERCENT);
                        txttutionfee.Text = Convert.ToString(Sessionvalues.TUITION_FEE);
                        float a, b;
                        a = float.Parse(txtadfee.Text);
                        b = float.Parse(txtadfee.Text);
                    }
                    calculate();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtgname.Text = txtfname.Text;
            txtgcnic.Text = txtcnic.Text;
            txtgcell.Text = txtfcell.Text;
            txtgoccupatio.Text = txtoccupation.Text;
            txtgmonthincom.Text = txtincom.Text;
            txtofficetell.Text = txtofficetel.Text;
            txtgcast.Text = txtcast.Text;
            txtgoffice.Text = txtofficeadress.Text;
        }

        private void txtotherfee_ModifiedChanged(object sender, EventArgs e)
        {
            calculate();
        }

        private void cbbgroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dvgstudent_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {
            if (cbbclass.Text != "" && cbbsection.Text != "" && cbbgroup.Text != "")
            {
                try
                {
                    var GetAccount = from c in db.TBLFEEMASTERs
                                     where c.STU_Class == classid
                                     select new { c.ADMISSION_FEE, c.TUITION_FEE, c.TUITION_FEE_PERCENT, c };

                    foreach (var Sessionvalues in GetAccount)
                    {
                        txtadfee.Text = Convert.ToString(Sessionvalues.ADMISSION_FEE);
                        txttutionfee.Text = Convert.ToString(Sessionvalues.TUITION_FEE);
                        txtdiscount.Text = Convert.ToString(Sessionvalues.TUITION_FEE_PERCENT);
                        txttutionfee.Text = Convert.ToString(Sessionvalues.TUITION_FEE);
                        float a, b;
                        a = float.Parse(txtadfee.Text);
                        b = float.Parse(txtadfee.Text);
                    }
                    calculate();
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message); }
            }
        }

        private void dvgstudent_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dvgstudent.Rows[e.RowIndex];
                if (row != null)
                dgv = row.Cells["NO"].Value.ToString();
                int dgva = Convert.ToInt16(dgv);
                var q = (from a in db.TBLADDMISSIONs
                where a.SID == dgva
                select a).SingleOrDefault();
                txtsystem.Text =Convert.ToString(q.SID);
                txtform.Text=q.ADMISSION_FORM;
                txtstudentname.Text=q.STUDENT_NAME ;
                txtdob.Text =Convert.ToString(q.STUDENT_DOB);
                txtpob.Text = q.PLACE_BIRTH ;
                bform.Text= q.STUDENT_NIC  ;
                cbbgender.Text=q.GENDER;
                txtriligion.Text = q.RELIGION  ;
                txtcell.Text=q.S_CELL_NO;
                txtsmail.Text=q.STUDENT_EMAIL_ADDRESS;
                if (q.ADMISSION_STATUS != null)
                {
                    ckbstatus.Checked = true;
                }
                else { ckbstatus.Checked = false; }
                txthomeadress.Text= q.HOME_ADDRESS;
                cbbBloodGroup.Text= q.BLOODGROUP;
                if (q != null)
                {
                    using (var ms = new MemoryStream(q.IMAGE))
                    {
                        using (var image = Image.FromStream(ms))
                        {
                            imgpicturebox.Image = (Image)image.Clone();
                        }
                    }
                }
                // q.IMAGE = convertfiletobyte(this.imgpicturebox.ImageLocation);
                txtfname.Text= q.FATHER_NAME ;
                txtcnic.Text= q.FATHER_NIC ;
                txtfcell.Text= q.FATHER_CELL_NO  ;
                txtoccupation.Text= q.FATHER_OCCUPATION ;
                txtincom.Text= q.MONTHLY_INCOM ;
                txtofficetel.Text= q.OFFICE_LANDLINE;
                txtcast.Text= q.FATHER_CAST;
                txtgcast.Text=q.FATHER_CAST;
                txtofficeadress.Text= q.BUSINESS_ADDRESS;
                lblSession.Text= q.CURRENTSESSION;   ///     check this again
                txtgname.Text= q.G_NAME;
                txtgcnic.Text=q.G_CNIC;
                txtgcell.Text=q.G_CELL;
                txtgoccupatio.Text=q.G_OCCUPATION;
                txtgmonthincom.Text=q.G_MONTHLY_INCOM;
                txtgcell.Text=q.G_CELL_NO;
                txtgoffice.Text=q.G_BUSINESS_ADDRESS;
                cbbedu1.Text= q.EDUCATION1;
                cbbedu2.Text=q.EDUCATION2;
                txtadminssion1.Text=q.ADMISSIONNO1;
                txtadmission2.Text=q.ADMISSIONNO2;
                txtpassyear.Text=q.YEAR1;
                txtpasyear2.Text=q.YEAR2;
                txtboard1.Text=q.BOARD_INSTITUTION1;
                txtboard2.Text=q.BOARD_INSTITUTION2;
                txtboard2.Text=q.BOARD_INSTITUTION2;
                cbbgrad1.Text=q.GRADE1;
                cbbgrad2.Text=q.GRADE2;
                txttmark.Text=q.TOTAL_MARKS1 ;
                txttmark2.Text=q.TOTAL_MARKS2  ;
                txtobtain1.Text=q.OBTAIN_MARKS1  ;
                txtobtain2.Text=q.OBTAIN_MARKS2  ;
                txtpercent1.Text=q.PERCENTAGE1  ;
                txtpercent2.Text=q.PERCENTAGE2  ;
                txtstname1.Text= q.STUDENTNAME1  ;
                txtstname2.Text= q.STUDENTNAME1  ;
                txtinwhich1.Text=q.CLAS1  ;
                txtinwhich2.Text=q.CLAS2  ;
                txtschoolname1.Text= q.SCHOOLNAME1  ;
                txtschool2.Text= q.SCHOOLNAME2 ;
                //q.ADMISSION_DATE = System.DateTime.Now;
                //q.CREATED_BY = txtcreatedby.Text;
                //q.CREATED_DATE = System.DateTime.Now;
            }
            else { }
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
