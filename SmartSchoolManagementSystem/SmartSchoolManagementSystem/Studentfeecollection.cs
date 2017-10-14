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
        smartschooldbEntities db = new smartschooldbEntities();

        int balnceSum, BID, STUDENTID,FEEID;

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
        //public static int DateTimeToInt(this DateTime theDate)
        //{
        //    int unixTime  =Convert.ToInt16(DateTime.Now);
        //    return unixTime;
        //}
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
                         select new { a.STUDENT_NAME,c.CID, c.Student_ID,s.FID, s.TUITION_FEE_PERCENT, a.FATHER_NAME, a.S_CELL_NO, a.IMAGE, g.Class, g.Section, s.TUITION_FEE, s.LATE_FEE, s.LATE_FEE_START,s.OTHER_FEE,s.BUS_FEE_PERCENT }).SingleOrDefault();
                //  PID = q.ID; join prod in products on category.ID equals prod.CategoryID


                STUDENTID = Convert.ToInt16(q.Student_ID);
                FEEID= Convert.ToInt16(q.FID);
                txtstudentname.Text = q.STUDENT_NAME;
                BID =Convert.ToInt16(q.CID);
                txtfathername.Text = q.FATHER_NAME;
                txtphone.Text = q.S_CELL_NO;
                txtclass.Text = q.Class;
                txtsection.Text = q.Section;
                txtdiscount.Text =Convert.ToString(q.TUITION_FEE_PERCENT);
                txtcurrentfee.Text = Convert.ToString(q.TUITION_FEE);
              
                 DateTime dt = DateTime.Now;
                // int dt = Convert.ToInt16(DateTime.Now);
                //    return unixTime;

               int z =Convert.ToInt16(dt.ToString("dd"));
              
               // int k = Convert.ToInt16(z) - y;
               // txtdate.Text = dt.ToString("dd");
                int x = Convert.ToInt16(q.LATE_FEE);
                int y = Convert.ToInt16(q.LATE_FEE_START);
                int k = z - y;
                txtfine.Text =Convert.ToString(x * k);
                int fine =Convert.ToInt16(txtfine.Text);
                int fee = Convert.ToInt16(txtcurrentfee.Text);
                txttottal.Text = Convert.ToString(fee + fine).ToString();
                calculatebalance();
                decimal totalfee = Convert.ToDecimal(txttottal.Text);
               // decimal discount = Convert.ToDecimal(txtdiscount.Text);
               
                //decimal discount =50;
                //decimal paybleamount= (-((discount / 100) * totalfee) + totalfee);
                decimal arrer = Convert.ToDecimal(txtarreres.Text);
                txtpayabe.Text =Convert.ToString (totalfee + arrer).ToString();


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
            balnceSum = Convert.ToInt16((from emp in db.TBLSTUDENTFEEDETAILS
                                         where emp.FID == BID
                                         select  emp.AMOUNT_PAID).Sum());
         int payable = Convert.ToInt16((from emp in db.TBLSTUDENTFEEDETAILS
                                         where emp.FID == BID
                                         select emp.TOTAL_FEE).Sum());

           // // Response.Write(string.Format("Addition of Salary is : {0} ", salarySum));

            int result = payable - balnceSum;
            txtarreres.Text = result.ToString();

        }

        private void txtpaid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                decimal paid =Convert.ToDecimal(txtpaid.Text);
                decimal payable = Convert.ToDecimal(txtpayabe.Text);
                txtblance.Text = (payable - paid).ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                TBLSTUDENTFEEDETAIL context = new TBLSTUDENTFEEDETAIL();
                context.SYSID = STUDENTID;
                context.FID = BID;
                context.TUITION_FEE = Convert.ToDecimal(txtcurrentfee.Text);
                context.BUS_FEE = Convert.ToDecimal(txtbusfee.Text);

                context.PRINTING_CHARGES = Convert.ToDecimal("0");
                context.OTHER_FEE = Convert.ToDecimal(txtother.Text);

                context.LATE_FEE = Convert.ToDecimal(txtfine.Text);
                context.TOTAL_FEE = Convert.ToDecimal(txttottal.Text);

                context.DISCOUNT = Convert.ToDecimal(txtdiscount.Text);
                context.AMOUNT_PAYABLE = Convert.ToDecimal(txtpayabe.Text);

                context.AMOUNT_PAID = Convert.ToDecimal(txtpaid.Text);
                context.BALANCE = Convert.ToDecimal(txtblance.Text);
                context.FEE_DATE = System.DateTime.Today;
                context.CREATEED_BY = "admin";
                context.CREATED_DATE = System.DateTime.Now;
                db.TBLSTUDENTFEEDETAILS.Add(context);
                db.SaveChanges();
                MessageBox.Show("added");




            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
           // balnceSum =Convert.ToInt16( (from emp in db.TBLSTUDENTFEEDETAILS
           //                  where emp.FID==7
           //                  select emp.BALANCE).Sum());

           //// Response.Write(string.Format("Addition of Salary is : {0} ", salarySum));
           //txtarreres.Text = balnceSum.ToString();
            ////  PID = q.ID; join prod in products on category.ID equals prod.CategoryID
            ////txtstudentname.Text = q.STUDENT_NAME;
            //int sum = Convert.ToInt16(q.BALANCE);

            //for (int i = 0; i < sum; i++)
            //{
            //    total +=sum;

            //}

            //txttottal.Text =Convert.ToString(total);

        }
    }
}