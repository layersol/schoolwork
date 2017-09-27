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
    public partial class Add_New_Session : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public Add_New_Session()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtacadmicsession.Text != "")
            {
                TblacadmicSession insert = new TblacadmicSession();
                insert.AcadmicSession = txtacadmicsession.Text;
                db.TblacadmicSessions.Add(insert);
                db.SaveChanges();
                MessageBox.Show("Acadmic Session Add Sucessfully.",
                "Acadmic Session",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            }
            else {
                MessageBox.Show("Please enter acadmic Session format(2012).",
  "Acadmic Session",
  MessageBoxButtons.OK,
  MessageBoxIcon.Exclamation,
  MessageBoxDefaultButton.Button1);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
