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
    public partial class StudentAccount : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        int _AMOUNT_PAID, BID, STUDENTID, FEEID;

        private void btnprint_Click(object sender, EventArgs e)
        {
            PrintRemainingBalance obj = new PrintRemainingBalance();
            obj.Show();
        }

        public StudentAccount()
        {
            InitializeComponent();
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
                         select new { a.STUDENT_NAME, c.CID, c.Student_ID, s.FID, s.TUITION_FEE_PERCENT, a.FATHER_NAME, a.S_CELL_NO, a.IMAGE, g.Class, g.Section, s.TUITION_FEE, s.LATE_FEE, s.LATE_FEE_START, s.OTHER_FEE, s.BUS_FEE_PERCENT }).SingleOrDefault();
                //  PID = q.ID; join prod in products on category.ID equals prod.CategoryID

                BID = Convert.ToInt16(q.CID);
                txtstudentname.Text = q.STUDENT_NAME;
                txtfathername.Text = q.FATHER_NAME;
                txtphone.Text = q.S_CELL_NO;
                txtclass.Text = q.Class;
                txtsection.Text = q.Section;
                calculatebalance();


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

        private void calculatebalance()
        {
            _AMOUNT_PAID = Convert.ToInt16((from emp in db.TBLSTUDENTFEEDETAILS
                                         where emp.FID == BID
                                         select emp.AMOUNT_PAID).Sum());
            int _AMOUNT_PAYABLE = Convert.ToInt16((from emp in db.TBLSTUDENTFEEDETAILS
                                           where emp.FID == BID
                                           select emp.AMOUNT_PAYABLE).Sum());

            // // Response.Write(string.Format("Addition of Salary is : {0} ", salarySum));
            lblpayable.Text = _AMOUNT_PAYABLE.ToString();
            lblrecived.Text = _AMOUNT_PAID.ToString();
            int result = _AMOUNT_PAYABLE - _AMOUNT_PAID;
            lblarreres.Text = result.ToString();

        }
    }
}