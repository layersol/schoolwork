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
    public partial class AddQuestions : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public AddQuestions()
        {
            InitializeComponent();
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
                var Getgroup = (from a in db.TblSections
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.Section }).ToList();

                cbbgroup.DataSource = Getgroup.ToList();
                cbbgroup.DisplayMember = "Names";
                cbbgroup.ValueMember = "ID";

                var Getsubject = (from a in db.Tbladdsubjects
                                      //where a.Class == cbbclass.SelectedItem.ToString()
                                  select new { a.ID, Names = a.SubjectName }).ToList();

                cbbsubject.DataSource = Getsubject.ToList();
                cbbsubject.DisplayMember = "Names";
                cbbsubject.ValueMember = "ID";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void AddQuestions_Load(object sender, EventArgs e)
        {
            Getdropdown();
            DGVquestion.Columns[0].Width = 600;
        }

        private void btnq_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DGVquestion.Rows.Count; i++)
            {

                // string amounts = dataGridView1.Rows[i].Cells[0].Value.ToString();

                TBLStaffAttendance context = new TBLStaffAttendance();
                // here rowindex will get through currentrow property of datagridview.
               // context.Empid = Convert.ToInt32(DGVquestion.Rows[i].Cells[0].Value);
                context.TimeIn = System.DateTime.Now;
                context.Attendance = "Present";
                context.DATE = System.DateTime.Now;
                context.Session = "Present";
                db.TBLStaffAttendances.Add(context);//InsertOnSubmit queries will automatic call thats the data context class handle it.
                db.SaveChanges();

            }
            MessageBox.Show("Saved");
        }
    }
}
