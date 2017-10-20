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
    public partial class ExpencesRecord : Form
    {
        public ExpencesRecord()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lkladd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Form item in this.MdiChildren) // check all opened forms
            {
                if (item.Name == "AddExpenseName") // check by form name if it's opene
                {
                    item.BringToFront(); // bring to front
                    return; //exit
                }
            }
            // if Myform is not opened
            // you know what it is
            AddExpenseName frm = new AddExpenseName();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }
    }
}
