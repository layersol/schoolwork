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
        int _AMOUNT_PAID, BID, groupid, FEEID,stdid ;
        string GroupVal;
        public static string Studentid = "";
        public static string studentname = "";
        public static string studentfather = "";
        public static string studentcell = "";
        public static string studentclass = "";
        public static string studensection = "";
        public static string Group = "";
        public static int sysid = 0;
        public static string payable = "";
        public static string recived = "";
        public static string remaingblnc = "";
        public static string img = "";

        public StudentAccount()
        {
            InitializeComponent();
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            Studentid = Convert.ToString(stdid);
            StudentFeeList obj = new StudentFeeList();
            obj.Show();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            try
            {
                sysid = Convert.ToInt16(txtstudentid.Text);
                Studentid = Convert.ToString(stdid);
                studentname = txtstudentname.Text;
                studentfather = txtfathername.Text;
                studentcell = txtphone.Text;
                studentclass = txtclass.Text;
                studensection = txtsection.Text;
                //  studensection = txtuser.Text;
                Group = GroupVal;

                payable = lblpayable.Text;
                recived = lblrecived.Text;
                remaingblnc = lblarreres.Text;
                // img = imgpicturebox.Image.ToString();


                PrintRemainingBalance obj = new PrintRemainingBalance();
                obj.Show();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void StudentAccount_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
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
                         select new {g.Group, a.STUDENT_NAME, c.CID, c.Student_ID, s.FID, s.TUITION_FEE_PERCENT, a.FATHER_NAME, a.S_CELL_NO, a.IMAGE, g.Class, g.Section, s.TUITION_FEE, s.LATE_FEE, s.LATE_FEE_START, s.OTHER_FEE, s.BUS_FEE_PERCENT }).SingleOrDefault();
                //  PID = q.ID; join prod in products on category.ID equals prod.CategoryID
                GroupVal = Convert.ToString(q.Group);
                stdid = Convert.ToInt16(q.Student_ID);
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