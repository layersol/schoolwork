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
    public partial class StudentIdCardForm : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
       int classid;
        public StudentIdCardForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Getdropdown()
        {
            try
            {
                var Getclass = (from a in db.Tblclasses
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.CLASSNAME }).ToList();
                cbbclass.DataSource = Getclass;
                cbbclass.DisplayMember = "Names";
                cbbclass.ValueMember = "ID";
                var Getgroup = (from a in db.tblgroupnames
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.Groupname }).ToList();

                cbbgroup.DataSource = Getgroup.ToList();
                cbbgroup.DisplayMember = "Names";
                cbbgroup.ValueMember = "ID";
                var Getmedium = (from a in db.tblmediums
                                     //where a.Class == cbbclass.SelectedItem.ToString()
                                 select new { a.ID, Names = a.Medium }).ToList();

                cbbmedium.DataSource = Getmedium.ToList();
                cbbmedium.DisplayMember = "Names";
                cbbmedium.ValueMember = "ID";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void StudentIdCardForm_Load(object sender, EventArgs e)
        {
            Getdropdown();
        }

        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {
            var Getsection = (from a in db.Tblclasssections
                              where a.Class == cbbclass.Text
                              select new { a.ID, Names = a.Section, }).ToList();
            cbbsection.DataSource = Getsection.ToList();
            cbbsection.DisplayMember = "Names";
            cbbsection.ValueMember = "ID";
        }
        public static int classidget = 0;
        private void btnidprint_Click(object sender, EventArgs e)
        {
            try
            {

                var q = (from a in db.Tblclasssections
                         where a.Class == cbbclass.Text && a.Section == cbbsection.Text && a.Group == cbbgroup.Text && a.Comments == cbbmedium.Text
                         select a).SingleOrDefault();

                classid = q.ID;

                foreach (Form item in this.MdiChildren) // check all opened forms
                {
                    if (item.Name == "studentidcard") // check by form name if it's opened
                    {
                        item.BringToFront(); // bring it front
                        return; //exit
                    }
                }
                classidget = classid;
                studentidcard frm = new studentidcard();
                //frm.MdiParent = this;
                frm.Show();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
