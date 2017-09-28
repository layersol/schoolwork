using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class addnewstudent : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
       // string getID;
        public addnewstudent()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && comboclass.Text != "" && combosection.Text != "" && txtnumber.Text != "")
                {
                    Tbladmissionprint context = new Tbladmissionprint();
                    context.Name = txtname.Text;
                    context.Class = comboclass.Text;
                    context.Section = combosection.Text;
                    context.CellNo = txtnumber.Text;
                    db.Tbladmissionprints.Add(context);
                    db.SaveChanges();
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("Please Fill All Field!",
    "Field Required",
    MessageBoxButtons.YesNoCancel,
    MessageBoxIcon.Warning);




                }
            }
            catch
            {
                MessageBox.Show("Somthing Wrong!");
            }


        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtname.Text = textInfo.ToTitleCase(txtname.Text);
            txtname.Select(txtname.Text.Length, 1);
        }

        private void addnewstudent_Load(object sender, EventArgs e)
        {
            //var qaNames = (from a in db.Tblclasses
            //              // where a.CLASS == cbbclass.Text
            //               select new { a.ID, Names = a.CLASSNAME, }).ToList();
            //comboclass.DataSource = qaNames.ToList();
            //comboclass.DisplayMember = "Names";
            //comboclass.ValueMember = "ID";
        }

        private void dgvnewadmission_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    Newadmission obj_open = new Newadmission();
                    obj_open.dgvr = dgvnewadmission.Rows[e.RowIndex];
                    obj_open.Show();
                    this.Hide();
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
            }

        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            admissionform objopen = new admissionform();
            objopen.MdiParent = this.MdiParent;
            objopen.Show();



        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}