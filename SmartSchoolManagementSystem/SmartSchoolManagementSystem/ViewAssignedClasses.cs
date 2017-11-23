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
    public partial class ViewAssignedClasses : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public ViewAssignedClasses()
        {
            InitializeComponent();
        }

        private void ViewAssignedClasses_Load(object sender, EventArgs e)
        {
            Getassignclass();
            Getdropdown();
            inptoff();
        }


        private void Getassignclass()
        {
            try
            {
                var val2 = (from u in db.TBLADDMISSIONs select u).Count() > 0;
                if (val2 != false)
                {

                    var query = from s in db.Tblclasssections
                                join h in db.TblTeacherInformations on s.Teacher equals h.TEACHERNAME
                                select new
                                {
                                    // NO = s.ID,
                                    Class = s.Class,
                                    Section = s.Section,
                                    Group = s.Group,
                                    Medium = s.Comments,
                                    Teacher = s.Teacher,
                                    Cell = h.CELLNO

                                };
                    dgdviewassign.DataSource = query.ToList();
                    dgdviewassign.Columns[0].Width = 60;
                }
                else
                {
                    MessageBox.Show("No Record Found at this time please click ok");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
        private void Getbyclass()
        {
            try
            {
                var val2 = (from u in db.TBLADDMISSIONs select u).Count() > 0;
                if (val2 != false)
                {

                    var query = from s in db.Tblclasssections
                                join h in db.TblTeacherInformations on s.Teacher equals h.TEACHERNAME
                                where s.Class == CBBCLASS.Text 
                                select new
                                {
                                    // NO = s.ID,
                                    Class = s.Class,
                                    Section = s.Section,
                                    Group = s.Group,
                                    Medium = s.Comments,
                                    Teacher = s.Teacher,
                                    Cell = h.CELLNO

                                };
                    dgdviewassign.DataSource = query.ToList();
                    dgdviewassign.Columns[0].Width = 60;
                }
                else
                {
                    MessageBox.Show("No Record Found at this time please click ok");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }


        private void Getsection()
        {
            try
            {
                var Getsection = (from a in db.Tblclasssections
                                  where a.Class == CBBCLASS.Text
                                  select new { a.ID, Names = a.Section, }).ToList();
                CBBSECTION.DataSource = Getsection.ToList();
                CBBSECTION.DisplayMember = "Names";
                CBBSECTION.ValueMember = "ID";

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }

        private void Getdropdown()
        {
            try
            {
                var Getclass = (from a in db.Tblclasses
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.CLASSNAME }).ToList();
                CBBCLASS.DataSource = Getclass;
                CBBCLASS.DisplayMember = "Names";
                CBBCLASS.ValueMember = "ID";

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }



        private void btngo_Click(object sender, EventArgs e)
        {
            if (rbtall.Checked==true)
            { Getassignclass(); }
            else { Getbyclass(); }
        }

        private void rbtall_CheckedChanged(object sender, EventArgs e)
        {
            inptoff();
        }

        private void rbtbyclass_CheckedChanged(object sender, EventArgs e)
        {
            inpton();
        }

        private void inpton()
        {
            CBBCLASS.Enabled = true;
            CBBSECTION.Enabled = true;
        }
        private void inptoff()
        {
            CBBCLASS.Enabled = false;
            CBBSECTION.Enabled = false;
        }
        private void CBBCLASS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Getsection();
        }
    }
}
   