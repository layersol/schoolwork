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
    public partial class ViewEnrolledStudents : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public ViewEnrolledStudents()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbsearchbyclass_SelectedValueChanged(object sender, EventArgs e)
        {
            var Getsection = (from a in db.Tblclasssections
                              where a.Class == cbbsearchbyclass.Text
                              select new { a.ID, Names = a.Section, }).ToList();
            cbbsearchbysection.DataSource = Getsection.ToList();
            cbbsearchbysection.DisplayMember = "Names";
            cbbsearchbysection.ValueMember = "ID";
        }
        private void Getdropdown()
        {
            try
            {
                var Getclass = (from a in db.Tblclasses
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.CLASSNAME }).ToList();
                cbbsearchbyclass.DataSource = Getclass;
                cbbsearchbyclass.DisplayMember = "Names";
                cbbsearchbyclass.ValueMember = "ID";

            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void GetSession()
        {
            try
            {
                var CurrentSession = from c in db.TblacadmicSessions select new { Session = c.AcadmicSession, };

                foreach (var Sessionvalues in CurrentSession)
                {
                    txtsession.Text = Convert.ToString(Sessionvalues.Session);
                }


            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void ViewEnrolledStudents_Load(object sender, EventArgs e)
        {
            if (rdball.Checked == true)

            {
                cbbsearchbyclass.Enabled = false;
                cbbsearchbysection.Enabled = false;
                // Getdropdown();
                GetSession();
            }
            else
            {
                Getdropdown();
                GetSession();
            }



        }

        private void btnview_Click(object sender, EventArgs e)
        {

            try
            {
                if (rdball.Checked == true)
                {

                    if ((from u in db.TBLSTUDENTENRROLs where u.ACADMICSESSION == txtsession.Text select u).Count() > 0)
                    {

                        var Getclass = (from a in db.TBLADDMISSIONs
                                        join d in db.TBLSTUDENTENRROLs on a.SID equals d.SystemId
                                        join g in db.Tblclasssections on d.CID equals g.ID
                                        where a.ADMISSION_STATUS == true && d.ACADMICSESSION == txtsession.Text
                                        select new
                                        {
                                            RollNo = d.Student_ID,
                                            Name = a.STUDENT_NAME,
                                            Father_Name = a.FATHER_NAME,
                                            Class = g.Class + " - " + g.Section + " - " + g.Group + " - " + g.Comments,
                                            DOB = a.STUDENT_DOB,
                                            Cell = a.S_CELL_NO,
                                            Address = a.HOME_ADDRESS
                                        }).ToList();
                        dgdview.DataSource = Getclass.ToList();
                        if (dgdview.Rows.Count != 0 && dgdview.Rows != null && dgdview.Rows.Count != 0)
                        {
                            dgdview.Columns[0].Width = 45;
                            dgdview.Columns[3].Width = 190;
                            dgdview.Columns[6].Width = 250;
                        }
                    }
                    else
                    {
                        //  MessageBox.Show("Record Not Found.");
                        Messagebox.show();
                    }
                }




                else if (rdbclass.Checked == true )
                {


                    if ((from a in db.Tblclasssections join p in db.TBLSTUDENTENRROLs on a.ID equals p.CID
                         where a.Class == cbbsearchbyclass.Text && a.Section == cbbsearchbysection.Text && p.ACADMICSESSION == txtsession.Text

                         select a).Count() > 0)
                    {

                        var Getclass = (from a in db.Tblclasssections
                                        join d in db.TBLSTUDENTENRROLs on a.ID equals d.CID
                                        join g in db.TBLADDMISSIONs on d.SystemId equals g.SID
                                        where a.Class == cbbsearchbyclass.Text && a.Section == cbbsearchbysection.Text && d.ACADMICSESSION == txtsession.Text
                                        select new
                                        {
                                            RollNo = d.Student_ID,
                                            Name = g.STUDENT_NAME,
                                            Father_Name = g.FATHER_NAME,
                                            Class = a.Class + " - " + a.Section + " - " + a.Group + " - " + a.Comments,
                                            DOB = g.STUDENT_DOB,
                                            Cell = g.S_CELL_NO,
                                            Address = g.HOME_ADDRESS
                                        }).ToList();
                        dgdview.DataSource = Getclass.ToList();
                        if (dgdview.Rows.Count != 0 && dgdview.Rows != null && dgdview.Rows.Count != 0)
                        {
                            dgdview.Columns[0].Width = 45;
                            dgdview.Columns[3].Width = 190;
                            dgdview.Columns[6].Width = 250;
                        }
                    }
                    else
                    {
                       
                        Messagebox.show();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rdball_CheckedChanged(object sender, EventArgs e)
        {
            if (rdball.Checked == true)

            {
                cbbsearchbyclass.Enabled = false;
                cbbsearchbysection.Enabled = false;
                cbbsearchbyclass.Text = "";
                cbbsearchbysection.Text = "";

                //Getdropdown();
                GetSession();
            }
          
        }

        private void rdbclass_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbclass.Checked == true)

            {
                cbbsearchbyclass.Enabled = true;
                cbbsearchbysection.Enabled = true;
                Getdropdown();
                GetSession();
            }
            
        }

        private void cbbsearchbyclass_SelectedIndexChanged(object sender, EventArgs e)
        {
            // dgdview.Rows.Clear();
            dgdview.DataSource = null;
        }
    }
}
