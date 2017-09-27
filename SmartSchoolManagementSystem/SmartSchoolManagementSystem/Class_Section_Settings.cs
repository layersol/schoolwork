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
    public partial class Class_Section_Settings : Form
    {
        public Class_Section_Settings()
        {
            InitializeComponent();
        }

        private void Class_Section_Settings_Load(object sender, EventArgs e)
        {
            disableallcontrol();
        }

        private void disableallcontrol()
        {
            txtclass.Enabled = false;
            txtsection.Enabled = false;
            txtfloorid.Enabled = false;
            txtgroup.Enabled = false;
            cbbteacher.Enabled = false;
            txtmaxstudent.Enabled = false;
            txtroomno.Enabled = false;
            txtcomments.Enabled = false;
            btnsave.Enabled = false;
            btnupdate.Enabled = false;
            
        }
        private void enableallcontrol()
        {
            txtclass.Enabled = true;
            txtsection.Enabled = true;
            txtfloorid.Enabled = true;
            txtgroup.Enabled = true;
            cbbteacher.Enabled = true;
            txtmaxstudent.Enabled = true;
            txtroomno.Enabled = true;
            txtcomments.Enabled = true;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;
            btnadd.Enabled = false;

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            enableallcontrol();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
