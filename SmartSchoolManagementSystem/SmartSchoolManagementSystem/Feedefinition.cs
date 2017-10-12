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
    public partial class Feedefinition : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public Feedefinition()
        {
            InitializeComponent();
            GetClass();
        }


        private void GetClass()
        {
            var qaNames = (from a in db.Tblclasses
                           orderby a.CLASSNAME
                           select a.CLASSNAME).Distinct();
            cbbclass.DataSource = qaNames.ToList();
            cbbclass.DisplayMember = "Names";
            cbbclass.ValueMember = "";
           // chbtransport.Visible = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (dtp.Text !="" & txttuitionfee.Text !="" & txtfeepercent.Text !="" & txttuitionfee.Text !="")
            //    {
            //        FeeMasterSetting savecontent = new FeeMasterSetting();
            //        savecontent.Month_year = dtp.Text;
            //        savecontent.Stu_Class = cbbclass.SelectedValue.ToString();
            //        savecontent.Tuition_Fee = txttuitionfee.Text;
            //        savecontent.Tuition_Fee_Percent = txtfeepercent.Text;
            //        savecontent.Bus_Fee_Percent = txtbusfee.Text;
            //        savecontent.Late_Fee_Start = txtLateFeeStart.Text;
            //        savecontent.Late_Fee = txtlatefee.Text;
            //        savecontent.Other_fee = txtotherfee.Text;
            //        db.FeeMasterSettings.Add(savecontent);
            //        db.SaveChanges();
            //    }
            //    else { MessageBox.Show("Please Fill all field!"); }
            //}
            //catch
            //{

            //}
        }

        private void cbbclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var qaNames = (from a in db.TblSections
            //               where a.CLASS == cbbclass.Text
            //               select new { a.ID, Names = a.SECTION, }).ToList();
            //cbbsection.DataSource = qaNames.ToList();
            //cbbsection.DisplayMember = "Names";
            //cbbsection.ValueMember = "ID";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
