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
    public partial class SubjectDefination : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();

        public SubjectDefination()
        {
            InitializeComponent();
            GetClass();
        }
        private void GetClass()
        {
            var qaNames = (from a in db.Tblclasssections
                           orderby a.Class
                           select a.Class).Distinct();
            cbbclass.DataSource = qaNames.ToList();
            cbbclass.DisplayMember = "Names";
            cbbclass.ValueMember = "";
        }
            private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubjectDefination_Load(object sender, EventArgs e)
        {

        }

        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var qaNames = (from a in db.Tblclasssections
                               where a.Class == cbbclass.Text
                               select new { a.ID, Names = a.Section, }).ToList();
                cbbsection.DataSource = qaNames.ToList();
                cbbsection.DisplayMember = "Names";
                cbbsection.ValueMember = "ID";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, ""); }
        }

        private void cbbsection_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                var group = (from a in db.Tblclasssections
                             where a.Class == cbbclass.Text && a.Section == cbbsection.Text
                             select new { a.ID, Names = a.Group, }).ToList();
                cbbgroup.DataSource = group.ToList();
                cbbgroup.DisplayMember = "Names";
                cbbgroup.ValueMember = "ID";

                var medium = (from a in db.Tblclasssections
                              where a.Class == cbbclass.Text && a.Section == cbbsection.Text
                              select new { a.ID, Names = a.Comments, }).ToList();
                cbbmedium.DataSource = medium.ToList();
                cbbmedium.DisplayMember = "Names";
                cbbmedium.ValueMember = "ID";

                var Teacher = (from a in db.TblTeacherInformations
                              where a.POSITION=="Teacher"
                              select new { a.ID, Names = a.TEACHERNAME, }).ToList();
                cbbteacher.DataSource = Teacher.ToList();
                cbbteacher.DisplayMember = "Names";
                cbbteacher.ValueMember = "ID";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, ""); }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                //var q = (from a in db.Tblclasssections
                //         where a.Class == cbbclass.Text && a.Section == cbbsection.Text && a.Group == cbbgroup.Text && a.Comments == cbbmedium.Text
                //         select a).SingleOrDefault();
                //int cid = q.ID;
                var item = db.Tbladdsubjects.SingleOrDefault(x => x.SubjectName =="");
                if (item == null)
                {
                    if (txttuitionfee.Text != "" && txtfeepercent.Text != "" && txttuitionfee.Text != "")
                    {
                        //Tbladdsubject savecontent = new Tbladdsubject();
                        //savecontent.Month_Year = session;
                        //savecontent.STU_Class = cid;
                        //savecontent.ADMISSION_FEE = Convert.ToDecimal(txtadmission.Text);
                        //savecontent.TUITION_FEE = Convert.ToDecimal(txttuitionfee.Text);
                        //savecontent.TUITION_FEE_PERCENT = Convert.ToDecimal(txtbusfee.Text);
                        //savecontent.BUS_FEE_PERCENT = Convert.ToDecimal(txtbusfee.Text);
                        //savecontent.LATE_FEE_START = Convert.ToDecimal(txtLateFeeStart.Text);
                        //savecontent.LATE_FEE = Convert.ToDecimal(txtlatefee.Text);
                        //savecontent.OTHER_FEE = Convert.ToDecimal(txtotherfee.Text);

                        //db.TBLFEEMASTERs.Add(savecontent);
                        //db.SaveChanges();
                    }
                    else { MessageBox.Show("Please Fill all field!"); }
                }
                else { MessageBox.Show("This Combination Deffination Already Exist"); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something Wrong");
            }
        }
    }
}
