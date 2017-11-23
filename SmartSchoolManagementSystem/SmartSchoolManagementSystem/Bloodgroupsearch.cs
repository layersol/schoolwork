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
    public partial class Bloodgroupsearch : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public Bloodgroupsearch()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {


                if ((from u in db.TBLADDMISSIONs where u.BLOODGROUP == cbbbloodsearch.Text select u).Count() > 0)
                {

                    var Getclass = (from a in db.TBLADDMISSIONs
                                    join d in db.TBLSTUDENTENRROLs on a.SID equals d.SystemId
                                    join g in db.Tblclasssections on d.CID equals g.ID
                                    where a.BLOODGROUP == cbbbloodsearch.Text
                                    select new
                                    {
                                        RollNo = d.Student_ID,
                                        Name = a.STUDENT_NAME,
                                        Blood = a.BLOODGROUP,
                                        Cell = a.S_CELL_NO,
                                        Class = g.Class,
                                        DOB = a.STUDENT_DOB,
                                        
                                        Address = a.HOME_ADDRESS
                                    }).ToList();
                    dgdview.DataSource = Getclass.ToList();
                if (dgdview.Rows.Count != 0 && dgdview.Rows != null && dgdview.Rows.Count != 0)
                {
                    dgdview.Columns[0].Width = 40;
                        dgdview.Columns[2].Width = 40;
                        dgdview.Columns[3].Width = 90;
                        dgdview.Columns[4].Width = 60;
                        dgdview.Columns[5].Width = 60;
                        dgdview.Columns[6].Width = 200;
                }
            }
                else
                {
                MessageBox.Show("Record Not Found.");
            }
        }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}           