using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class MDIParent : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        private int childFormNumber = 0;
        string val1, val2;
        [DllImport("user32.dll")]
        internal static extern short GetKeyState(int keyCode);

        public MDIParent()
        {
            InitializeComponent();
            //initilizefun();
        }
        private void initilizefun()
        {
            UpdateNUMLock();
            UpdateCAPSLock();
            UpdateInsert();
            string date = DateTime.Now.ToString("dddd-MMMM-yyyy hh:mm:ss");
           // currenttime.Text = date;
        }
        private void UpdateNUMLock()
        {
            //bool NumLock =G
            bool NumLock = (GetKeyState((int)Keys.NumLock)) != 0;

            if (NumLock)
            {
                //lblNum.Text = "NUM";
                //lblNum.Enabled = true;
            }
            else
            {
                //lblNum.Text = "NUM";
                //lblNum.Enabled = false;
            }

            this.Refresh();
        }
        private void UpdateInsert()
        {
            //bool NumLock =G
            bool InsLock = (GetKeyState((int)Keys.Insert)) != 0;

            if (InsLock)
            {
                //lblInsert.Text = "INS";
                //lblInsert.Enabled = true;
            }
            else
            {
                //lblInsert.Text = "INS";
                //lblInsert.Enabled = false;
            }

            this.Refresh();
        }
        private void UpdateCAPSLock()
        {
            //bool NumLock =G
            bool CapsLock = (GetKeyState((int)Keys.CapsLock)) != 0;

            if (CapsLock)
            {
                //lblCaps.Text = "CAPS";
                //lblCaps.Enabled = true;
            }
            else
            {
                //lblCaps.Text = "CAPS";
                //lblCaps.Enabled = false;
            }

            this.Refresh();
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void printAdmissionFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "addnewstudent") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }
            addnewstudent frm = new addnewstudent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Newadmission") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }       
            Newadmission frm = new Newadmission();
            frm.MdiParent = this;
            frm.Show();


        }

        private void addStaffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "TeachersttafInformation") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }
            TeachersttafInformation frm = new TeachersttafInformation();
            frm.MdiParent = this;
            frm.Show();


        }

        private void MDIParent_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Insert)
            {
                UpdateInsert();
            }
            else if (e.KeyData == Keys.NumLock)
            {
                UpdateNUMLock();
            }
            else if (e.KeyData == Keys.CapsLock)
            {
                UpdateCAPSLock();
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Newadmission") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            Newadmission frm = new Newadmission();
            frm.MdiParent = this;
            frm.Show();
        }

        private void schoolInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "schoolsettings") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            schoolsettings frm = new schoolsettings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void feeCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FeeCollection") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            FeeCollection frm = new FeeCollection();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viaSmSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void arrearsAndBalenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentAccount obj = new StudentAccount();
            obj.MdiParent = this;
            obj.Show();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViewEnrolledStudents") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            ViewEnrolledStudents frm = new ViewEnrolledStudents();
            frm.MdiParent = this;
            frm.Show();
        }

        private void attendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "DailyAttendance") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            DailyAttendance frm = new DailyAttendance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViewAttendance") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            ViewAttendance frm = new ViewAttendance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void studentIDCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "StudentIdCardForm") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            StudentIdCardForm frm = new StudentIdCardForm();
            frm.MdiParent = this;
            frm.Show();
        }

        private void configuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ConfiguarFingerPrints") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            ConfiguarFingerPrints frm = new ConfiguarFingerPrints();
            frm.MdiParent = this;
            frm.Show();
        }

        private void submitVacationWorkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Vacationworkcollection") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            Vacationworkcollection frm = new Vacationworkcollection();
            frm.MdiParent = this;
            frm.Show();
        }

        private void printJoiningFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Teacherinfoprintform") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            Teacherinfoprintform frm = new Teacherinfoprintform();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewStaffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViewStaffInformation") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            ViewStaffInformation frm = new ViewStaffInformation();
            frm.MdiParent = this;
            frm.Show();
        }

        private void staffAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "StaffAttendance") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            StaffAttendance frm = new StaffAttendance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewAttendanceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViewStaffAttendance") // check by form name if it's opened
                {
                    item.BringToFront(); //bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ViewStaffAttendance frm = new ViewStaffAttendance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void assignClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "AssignClass") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            AssignClass frm = new AssignClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viewClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViewAssignedClasses") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ViewAssignedClasses frm = new ViewAssignedClasses();
            frm.MdiParent = this;
            frm.Show();

        }

        private void printStaffCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "PrintStaffCard") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            PrintStaffCard frm = new PrintStaffCard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void iDCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "IDCard") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            IDCard frm = new IDCard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void resultCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ResultCard") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ResultCard frm = new ResultCard();
            frm.MdiParent = this;
            frm.Show();
        }

        private void feeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FeeList") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            FeeList frm = new FeeList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void remainingFeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "RemainingFee") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            RemainingFee frm = new RemainingFee();
            frm.MdiParent = this;
            frm.Show();
        }

        private void defualterListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "DefaulterListByStudent") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            DefaulterListByStudent frm = new DefaulterListByStudent();
            frm.MdiParent = this;
            frm.Show();
        }

        private void defualterListByClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "DefaulterListByClass") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            DefualerListByClass frm = new DefualerListByClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void defualterListByMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "DefualterListByMonth") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            DefualterListByMonth frm = new DefualterListByMonth();
            frm.MdiParent = this;
            frm.Show();
        }

        private void defualterListBySessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "DefualterListBySession") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            DefualterListBySession frm = new DefualterListBySession();
            frm.MdiParent = this;
            frm.Show();
        }

        private void printFeeRecipetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FeeRecipet") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            FeeRecipet frm = new FeeRecipet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void schoolLeavingCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SchoolLeavingCertificate") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SchoolLeavingCertificate frm = new SchoolLeavingCertificate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void chracterCertificateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ChracterCertificate") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ChracterCertificate frm = new ChracterCertificate();
            frm.MdiParent = this;
            frm.Show();
        }

        private void MDIParent_Load(object sender, EventArgs e)
        {

            try
            {
                tsluser.Text = "Welcome  " + Login.SetValueForText + "  You Logged In  " + System.DateTime.Now;

                var Getschool = from c in db.Tblschoolsettings

                                select new
                                {
                                    Getschool = c.SchoolName,
                                    Getaddress = c.FIRSTADDRESS,
                                    GETAdress = c.SECONDADDRESS

                                };
                foreach (var GetSchoolInfo in Getschool)
                {
                    //String CompanyName = "Layer Solution Software Development Company LMT";
                    val1 = Convert.ToString(GetSchoolInfo.Getschool + " ( " + GetSchoolInfo.Getaddress + " " + GetSchoolInfo.GETAdress + " ) ");


                }
                var GetSession = from c in db.TblacadmicSessions

                                 select new
                                 {
                                     Session = c.AcadmicSession,

                                 };
                foreach (var GetsessionInfo in GetSession)
                {
                    //String CompanyName = "Layer Solution Software Development Company LMT";
                    string sess = "ACADMIC SESSION :";
                    val2 = Convert.ToString(GetsessionInfo.Session).ToUpper();
                    this.Text = val1 + " : : " + sess + " " + val2 + "";


                }
            }
            catch (Exception ex)
            { MessageBox.Show("Database connection Error Please check your server. ",ex.Message); }

        }
    }
} 
