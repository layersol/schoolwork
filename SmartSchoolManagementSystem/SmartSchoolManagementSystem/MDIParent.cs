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
            this.Close();
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
            addnewstudent _obj_atten = new addnewstudent();
            _obj_atten.MdiParent = this;
            _obj_atten.Show();
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Newadmission obj_open = new Newadmission();
           // obj_open.MdiParent = this;
            //obj_open.Show();

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

        private void addStaffInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeachersttafInformation obj_open = new TeachersttafInformation();
            obj_open.BringToFront();
            obj_open.MdiParent = this;
            obj_open.Show();



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

        private void MDIParent_Load(object sender, EventArgs e)
        {

           // toolStripLabel2.Text = LogIn.SetValueForText;
            var Getschool = from c in db.Tblschoolsettings

                            select new
                            {
                                Getschool = c.SchoolName,
                                Getaddress=c.FIRSTADDRESS,
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
    }
}
