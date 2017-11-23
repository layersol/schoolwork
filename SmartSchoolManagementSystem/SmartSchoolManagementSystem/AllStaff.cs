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
    public partial class AllStaff : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string session;
        public AllStaff()
        {
            InitializeComponent();
            GetSession();
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            var Getclass = (from a in db.TblTeacherInformations
                          
                          //  where a.CID == ClsId
                            select new
                            {
                              ID=a.ID,
                              Name=a.TEACHERNAME,
                              Position=a.POSITION,
                              Csession=session,
                            }).ToList();
            dgvattendace.DataSource = Getclass.ToList();
        }

        private void btngap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvattendace.Rows.Count ; i++)
            {

                // string amounts = dataGridView1.Rows[i].Cells[0].Value.ToString();

                TBLStaffAttendance context = new TBLStaffAttendance();
                // here rowindex will get through currentrow property of datagridview.
                context.Empid = Convert.ToInt32(dgvattendace.Rows[i].Cells[0].Value);
                context.TimeIn = System.DateTime.Now;
                context.Attendance ="Present";
                context.DATE = System.DateTime.Now;
                context.Session = "Present";
                db.TBLStaffAttendances.Add(context);//InsertOnSubmit queries will automatic call thats the data context class handle it.
                db.SaveChanges();

            }
            MessageBox.Show("Saved");
        }
    }
}
