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
    public partial class FeeRecipet : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();

        public FeeRecipet()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int sysid = Convert.ToInt16(txtsearch.Text);
            var Getclass = (from a in db.TBLSTUDENTFEEDETAILS

                            where a.SYSID == sysid
                            select new
                            {
                              Receipt= a.SFID
                            }).ToList();
            dgrecipt.DataSource = Getclass.ToList();


            
        }
    }
}
