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
    public partial class Classandsectiondefination : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string dgv;
        public Classandsectiondefination()
        {
            InitializeComponent();
        }
        private void Getclass()
        {
            var qaNames = (from a in db.Tblclasses
                               //  from b in db.TblSections
                           select new
                           {
                               a.ID,
                               Classname = a.CLASSNAME,

                           });
            cbbclass.DataSource = qaNames.ToList();
            cbbclass.DisplayMember = "Classname";
            cbbclass.ValueMember = "ID";

            var Section = (from b in db.TblSections
                               //  from b in db.TblSections
                           select new
                           {
                               b.ID,
                               Section = b.Section
                           });

            cbbsection.DataSource = Section.ToList();
            cbbsection.DisplayMember = "Section";
            cbbsection.ValueMember = "ID";

            var STaff = (from b in db.TblTeacherInformations
                             //  from b in db.TblSections
                         select new
                         {
                             b.ID,
                             staff = b.TEACHERNAME
                         });

            cbbteacher.DataSource = STaff.ToList();
            cbbteacher.DisplayMember = "staff";
            cbbteacher.ValueMember = "ID";

            //var GetTeacher = (from c in db.TblTeacherInformations
            //                   //  from b in db.TblSections
            //               select new
            //               {

            //               });

            //comboBox2.DataSource = GetTeacher.ToList();
            //comboBox2.DisplayMember = "Section";
            //comboBox2.ValueMember = "ID";
        }
        private void btnsave_Click(object sender, EventArgs e)
        {

        }
        private void Classandsectiondefination_Load(object sender, EventArgs e)
        {
            Getclass();
            txtcreationdate.Text = System.DateTime.Now.ToString();
            txtupdationby.Text = System.DateTime.Now.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void Insetrecord()
        {
            try
            {
                Tblclasssection objin = new Tblclasssection();
                objin.Class = cbbclass.Text;
                objin.Section = cbbsection.Text;
                objin.Group = txtgroup.Text;
                objin.Teacher = cbbteacher.Text;
                objin.admissionfee = Convert.ToDecimal(txttuitionfee.Text);
                objin.Fee = Convert.ToDecimal(txtmfee.Text);
                objin.examfee = Convert.ToDecimal(txtexamfee.Text);
                objin.Maxstudent = txtmaxstudent.Text;
                objin.RoomNo = txtroom.Text;
                objin.FloorId = txtfloor.Text;
                objin.Acadmic_Session = "2017-2018";
                objin.CreatedBy = "ali";
                objin.Createddate = Convert.ToDateTime(txtcreationdate.Text);
                db.Tblclasssections.Add(objin);
                db.SaveChanges();
            }
            catch (Exception e)
            { MessageBox.Show(e.Message); }
        }
        private void btnsave_Click_1(object sender, EventArgs e)
        {
            Insetrecord();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var val2 = (from u in db.Tblclasssections
                        select u).Count() > 0;
            if (val2 != false)
            {

                var query = from s in db.Tblclasssections

                            select new
                            {
                                SrNo = s.ID,
                                Class = s.Class,
                                Section = s.Section,
                                Group = s.Group,

                                Teacher = s.Teacher,

                                Maxstudent = s.Maxstudent,
                                //Floor=s.FloorId,
                                //RoomNo=s.RoomNo,
                                //admissionfee=s.admissionfee,
                                //Fee=s.Fee,
                                //examfee=s.examfee,

                                CreatedBy = s.CreatedBy,
                                CreationDate = s.Createddate,
                                Updatedby = s.Updatedby,
                                Updateddate = s.Updateddate,

                            };
                dgvclass.DataSource = query.ToList();
                dgvclass.Columns[0].Width = 50;
                dgvclass.Columns[1].Width = 50;
                //DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn();
                //dgvCmb.ValueType = typeof(bool);
                //dgvCmb.Name = "Chk";
                //dgvCmb.HeaderText = "CheckBox";
                //dgvclass.Columns.Add(dgvCmb);

            }
            else
            {
                MessageBox.Show("false");
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvclass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvclass.Rows[e.RowIndex];
                if (row != null)


                    dgv = row.Cells["SrNo"].Value.ToString();
                int dgva = Convert.ToInt16(dgv);
                var q = (from a in db.Tblclasssections
                         where a.ID == dgva
                         select a).SingleOrDefault();
                cbbclass.Text = q.Class;
                cbbsection.Text = q.Section;
                txtgroup.Text = q.Group;
                cbbteacher.Text = q.Teacher;
                txttuitionfee.Text = Convert.ToString(q.admissionfee);
                txtmfee.Text = Convert.ToString(q.Fee);
                txtexamfee.Text = Convert.ToString(q.examfee);
                txtmaxstudent.Text = q.Maxstudent;
                txtroom.Text = q.RoomNo;
                txtfloor.Text = q.FloorId;
                q.Acadmic_Session = "2017-2018";
                txtcreatedby.Text = q.CreatedBy;
                txtcreationdate.Text = Convert.ToString(q.Createddate);
            }
            else { }
        }

        private void dgvclass_RowHeaderCellChanged(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dgvclass_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvclass_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            //foreach (DataGridViewRow dgvr in dgvclass.Rows)
            //{
            //    int id = Convert.ToInt32(dgvr.Cells[0].Value);
            //   // int ah = Convert.ToInt32(dgvr.Cells[1].Value);

            //}
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgvclass.Rows[0];
            if (row != null)


                dgv = row.Cells["SrNo"].Value.ToString();
            int dgva = Convert.ToInt16(dgv);
            Tblclasssection objin = db.Tblclasssections.Single(p => p.ID == dgva);
            // decimal qty = Convert.ToDecimal(product.quentity);

            if (objin != null)
            {
                objin.Class = cbbclass.Text;
                objin.Section = cbbsection.Text;
                objin.Group = txtgroup.Text;
                objin.Teacher = cbbteacher.Text;
                objin.admissionfee = Convert.ToDecimal(txttuitionfee.Text);
                objin.Fee = Convert.ToDecimal(txtmfee.Text);
                objin.examfee = Convert.ToDecimal(txtexamfee.Text);
                objin.Maxstudent = txtmaxstudent.Text;
                objin.RoomNo = txtroom.Text;
                objin.FloorId = txtfloor.Text;
                objin.Acadmic_Session = "0000";
                //  objin.CreatedBy = "ali";
                // objin.Createddate = Convert.ToDateTime(txtcreationdate.Text);
                objin.Updatedby = txtupdatedby.Text;
                objin.Updateddate = Convert.ToDateTime(txtupdationby.Text);
                db.SaveChanges();
                MessageBox.Show("Updated", "Attention");
            }
            else { }
        }
    }
}