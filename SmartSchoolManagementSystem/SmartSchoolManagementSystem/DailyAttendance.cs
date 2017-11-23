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
    public partial class DailyAttendance : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public DailyAttendance()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            TBLAttendance context = new TBLAttendance();
        }

        private void btngap_Click(object sender, EventArgs e)
        {
            Attendanceall obj = new Attendanceall();
            obj.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int val = Convert.ToInt32(txtstudentid.Text);
                var q = (from a in db.TBLADDMISSIONs
                         join c in db.TBLSTUDENTENRROLs on a.SID equals c.SystemId
                         join s in db.TBLFEEMASTERs on c.CID equals s.STU_Class
                         join g in db.Tblclasssections on c.CID equals g.ID
                         //join g in db.t
                         where a.SID == val
                         select new { g.Group, a.STUDENT_NAME, c.CID, c.Student_ID, s.FID, s.TUITION_FEE_PERCENT, a.FATHER_NAME, a.S_CELL_NO, a.IMAGE, g.Class, g.Section, s.TUITION_FEE, s.LATE_FEE, s.LATE_FEE_START, s.OTHER_FEE, s.BUS_FEE_PERCENT }).SingleOrDefault();
                //  PID = q.ID; join prod in products on category.ID equals prod.CategoryID
              //  GroupVal = Convert.ToString(q.Group);
              //  stdid = Convert.ToInt16(q.Student_ID);
              //  BID = Convert.ToInt16(q.CID);
                txtname.Text = q.STUDENT_NAME;
                txtfname.Text = q.FATHER_NAME;
               // txtphone.Text = q.S_CELL_NO;
                txtclass.Text = q.Class;
                txtsection.Text = q.Section;
               // calculatebalance();


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
