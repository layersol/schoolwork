using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class Studentfeecollection : Form
    {
        smartschooldbEntities1 db = new smartschooldbEntities1();
        public Studentfeecollection()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(txtstudentid.Text);
                var q = (from a in db.TBLADDMISSIONs
                         join c in db.TBLSTUDENTENRROLs on a.SID equals c.SystemId
                         join s in db.TBLFEEMASTERs on c.CID equals s.STU_Class
                         //join g in db.t
                         where a.SID == val
                         select new { a.STUDENT_NAME, a.FATHER_NAME, a.S_CELL_NO, a.IMAGE, c.CLASSNAME, c.SECTION,s.TUITION_FEE }).SingleOrDefault();
                //  PID = q.ID; join prod in products on category.ID equals prod.CategoryID
                txtstudentname.Text = q.STUDENT_NAME;

                txtfathername.Text = q.FATHER_NAME;
                txtphone.Text = q.S_CELL_NO;
                txtclass.Text = q.CLASSNAME;
                txtsection.Text = q.SECTION;
                txtcurrentfee.Text = Convert.ToString(q.TUITION_FEE);
                // imgpicturebox.ImageLocation =Convert.ToString(q.LOGO);
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
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}