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
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViaSMS") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            ViaSMS frm = new ViaSMS();
            frm.MdiParent = this;
            frm.Show();
        }

        private void arrearsAndBalenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "StudentAccount") // check by form name if it's opened
                {
                    item.BringToFront(); // bring it front
                    return; //exit
                }
            }

            // if MyForm is not opened
            // you know what it is
            StudentAccount frm = new StudentAccount();
            frm.MdiParent = this;
            frm.Show();
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

        private void expenceRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExpencesRecord") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExpencesRecord frm = new ExpencesRecord();
            frm.MdiParent = this;
            frm.Show();
        }

        private void staffSalaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "StaffSalary") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            StaffSalary frm = new StaffSalary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fundProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FundProcess") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            FundProcess frm = new FundProcess();
            frm.MdiParent = this;
            frm.Show();
        }

        private void editFeeRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "EditFeeReocrd") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            EditFeeReocrd frm = new EditFeeReocrd();
            frm.MdiParent = this;
            frm.Show();
        }

        private void feeCollectionUserConsolidateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Studentfeecollection") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            Studentfeecollection frm = new Studentfeecollection();
            frm.MdiParent = this;
            frm.Show();
        }

        private void recievePaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "RecievePayment") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            RecievePayment frm = new RecievePayment();
            frm.MdiParent = this;
            frm.Show();
        }

        private void admissionFeeCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "AdmissionFeeCollection") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            AdmissionFeeCollection frm = new AdmissionFeeCollection();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fundDefualtersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FundDefaulters") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            FundDefaulters frm = new FundDefaulters();
            frm.MdiParent = this;
            frm.Show();
        }

        private void rollNoSlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "RollNoSlip") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            RollNoSlip frm = new RollNoSlip();
            frm.MdiParent = this;
            frm.Show();
        }

        private void changeClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ChangeClass") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ChangeClass frm = new ChangeClass();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exmainationTermsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExaminationTerms") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExaminationTerms frm = new ExaminationTerms();
            frm.MdiParent = this;
            frm.Show();
        }

        private void vacationWorkProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "VacationWorkProcess") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            VacationWorkProcess frm = new VacationWorkProcess();
            frm.MdiParent = this;
            frm.Show();
        }

        private void makeDateSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "MakeDateSheet") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            MakeDateSheet frm = new MakeDateSheet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void examinationRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExaminationRecord") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExaminationRecord frm = new ExaminationRecord();
            frm.MdiParent = this;
            frm.Show();
        }

        private void progressReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ProgressReport") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ProgressReport frm = new ProgressReport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sendResaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SendResult") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SendResult frm = new SendResult();
            frm.MdiParent = this;
            frm.Show();
        }

        private void examPaperHeaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExamPaperHeader") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExamPaperHeader frm = new ExamPaperHeader();
            frm.MdiParent = this;
            frm.Show();
        }

        private void createExamPaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "CreatExamPaper") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            CreatExamPaper frm = new CreatExamPaper();
            frm.MdiParent = this;
            frm.Show();
        }

        private void saveQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SaveQuestions") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SaveQuestions frm = new SaveQuestions();
            frm.MdiParent = this;
            frm.Show();
        }

        private void paperFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "PaperFunds") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            PaperFunds frm = new PaperFunds();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Add_Class") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            Add_Class frm = new Add_Class();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mobilePhoneSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Phonesetting") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            Phonesetting frm = new Phonesetting();
            frm.MdiParent = this;
            frm.Show();
        }

        private void expencesDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExpencesDefination") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExpencesDefination frm = new ExpencesDefination();
            frm.MdiParent = this;
            frm.Show();
        }

        private void addSectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "AddSection") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            AddSection frm = new AddSection();
            frm.MdiParent = this;
            frm.Show();
        }

        private void classMapingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ClassMaping") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ClassMaping frm = new ClassMaping();
            frm.MdiParent = this;
            frm.Show();
        }

        private void classFeeDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ClassFeeDefination") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ClassFeeDefination frm = new ClassFeeDefination();
            frm.MdiParent = this;
            frm.Show();
        }

        private void subjectDefinationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SubjectDefination") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SubjectDefination frm = new SubjectDefination();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sessionSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SessionSetting") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SessionSetting frm = new SessionSetting();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exportContactsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExportContactsList") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExportContactsList frm = new ExportContactsList();
            frm.MdiParent = this;
            frm.Show();
        }

        private void exportContactSelectiveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ExportContactsSelective") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ExportContactsSelective frm = new ExportContactsSelective();
            frm.MdiParent = this;
            frm.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "Backup") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            Backup frm = new Backup();
            frm.MdiParent = this;
            frm.Show();
        }

        private void factoryRestoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "FactoryRestore") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            FactoryRestore frm = new FactoryRestore();
            frm.MdiParent = this;
            frm.Show();
        }

        private void userAndRightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "UserAndRights") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            UserAndRights frm = new UserAndRights();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viaEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViaEmail") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ViaEmail frm = new ViaEmail();
            frm.MdiParent = this;
            frm.Show();
        }

        private void viaCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "ViaCall") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            ViaCall frm = new ViaCall();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sMSDateSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SMSDateSheet") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SMSDateSheet frm = new SMSDateSheet();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "SendFeedback") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            SendFeedback frm = new SendFeedback();
            frm.MdiParent = this;
            frm.Show();
        }

        private void registerProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "RegisterProduct") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            RegisterProduct frm = new RegisterProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "TechnicalSupport") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            TechnicalSupport frm = new TechnicalSupport();
            frm.MdiParent = this;
            frm.Show();
        }

        private void keyboardAccessibilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "KeyboardAccessibility") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            KeyboardAccessibility frm = new KeyboardAccessibility();
            frm.MdiParent = this;
            frm.Show();
        }

        private void aboutSSMSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "AboutSSMS") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            AboutSSMS frm = new AboutSSMS();
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
