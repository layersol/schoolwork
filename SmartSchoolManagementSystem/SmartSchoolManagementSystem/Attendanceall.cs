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
    public partial class Attendanceall : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string session;
        int ClsId;
        public Attendanceall()
        {
            InitializeComponent();
            Getdropdown();

        }
        private void CheckboxColumn_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvattendace.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[0];
                if (chk.Value == chk.FalseValue || chk.Value == null)
                {
                    chk.Value = chk.TrueValue;
                }
                else
                {
                    chk.Value = chk.FalseValue;
                }

            }
            dgvattendace.EndEdit();
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

        private void GetSession()
        {
            try
            {
                var CurrentSession = from c in db.TblacadmicSessions select new { Session = c.AcadmicSession, };

                foreach (var Sessionvalues in CurrentSession)
                {
                    session = Convert.ToString(Sessionvalues.Session);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
        private void cbbclass_SelectedValueChanged(object sender, EventArgs e)
        {
            var Getsection = (from a in db.Tblclasssections
                              where a.Class == cbbclass.Text
                              select new { a.ID, Names = a.Section, }).ToList();
            cbbsection.DataSource = Getsection.ToList();
            cbbsection.DisplayMember = "Names";
            cbbsection.ValueMember = "ID";



            //if ((from u in db.TBLSTUDENTENRROLs where u.ACADMICSESSION == session select u).Count() > 0)
            //{




        }



        private void btngap_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvattendace.Rows.Count - 1; i++)
            {

                TBLAttendance context = new TBLAttendance();
                // here rowindex will get through currentrow property of datagridview.

                //if (dgvattendace.Rows[i].Cells[0].Value != null)
                //{
                //    context.Attendance = "Present";
                // }
                //else { context.Attendance = "Absent"; }
                context.SYSID = Convert.ToInt16(dgvattendace.Rows[i].Cells[1].Value);
                context.STDID = Convert.ToInt16(dgvattendace.Rows[i].Cells[2].Value);
                context.ClassID = ClsId;
                context.TimeIn = System.DateTime.Now;
               
                context.DATE = System.DateTime.Now;
                context.Session =(dgvattendace.Rows[i].Cells[7].Value).ToString();

                db.TBLAttendances.Add(context);//InsertOnSubmit queries will automatic call thats the data context class handle it.
                db.SaveChanges();
                //==================


                // rowindex = 0;
                // decreasestock();
            }
        MessageBox.Show("Saved");
        }
       


        private void Attendanceall_Load(object sender, EventArgs e)
        {

        }

        private void btnselect_Click(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click_1(object sender, EventArgs e)
        {
            DataGridViewCheckBoxColumn CheckboxColumn = new DataGridViewCheckBoxColumn();
            CheckboxColumn.TrueValue = true;
            CheckboxColumn.FalseValue = false;
            CheckboxColumn.Width = 100;
            dgvattendace.Columns.Add(CheckboxColumn);
            dgvattendace.Rows.Add(1);

            var classid = from c in db.Tblclasssections
                          where c.Class == cbbclass.Text &&
                          c.Section == cbbsection.Text &&
                          c.Group == cbbgroup.Text &&
                          c.Comments == cbbmedium.Text

                          select new { cid = c.ID, };

            foreach (var Sessionvalues in classid)
            {
                ClsId = Convert.ToInt16(Sessionvalues.cid);
            }
            var Getclass = (from a in db.TBLSTUDENTENRROLs
                            join d in db.TBLADDMISSIONs on a.SystemId equals d.SID
                            join g in db.Tblclasssections on a.CID equals g.ID
                            where a.CID == ClsId
                            select new
                            {
                                RollNo = a.Student_ID,
                                systemid=a.SystemId,
                                Name = d.STUDENT_NAME,
                                Father_Name = d.FATHER_NAME,
                                Class = g.Class + " - " + g.Section + " - " + g.Group + " - " + g.Comments,
                                Session = a.ACADMICSESSION
                            }).ToList();
                            dgvattendace.DataSource = Getclass.ToList();



            //if (dgvattendace.Rows.Count != 0 && dgvattendace.Rows != null && dgvattendace.Rows.Count != 0)
            //{
            //    dgvattendace.Columns[0].Width = 45;
            //    dgvattendace.Columns[3].Width = 190;
            //    dgvattendace.Columns[6].Width = 250;
            //}
        }
    }
}