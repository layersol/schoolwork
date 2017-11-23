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
    public partial class Addsubject : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();

        public Addsubject()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
              
                var item = db.Tbladdsubjects.SingleOrDefault(x => x.SubjectName ==txtsubname.Text);
                if (item == null)
                {
                    if (txtsubname.Text != "" && txttotalmrks.Text != "" && txtpassing.Text != "")
                    {
                        Tbladdsubject savecontent = new Tbladdsubject();
                        savecontent.SubjectName = txtsubname.Text;
                        savecontent.TotalMarks =Convert.ToDecimal(txttotalmrks.Text);
                        savecontent.PassingMarks = Convert.ToDecimal(txtpassing.Text);
                        

                        db.Tbladdsubjects.Add(savecontent);
                        db.SaveChanges();
                        LoadSerial();
                        MessageBox.Show("Subject add!");
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
        private void LoadSerial()
        {
            //int i = 1;
            //foreach (DataGridViewRow row in DGVSubject.Rows)
            //{
            //    row.Cells["SNo"].Value = i; i++;
            //}

            var viewsub = db.Tbladdsubjects.ToList();
            DGVSubject.DataSource = viewsub.ToList();
            DGVSubject.Columns[0].Width = 45;
            DGVSubject.Columns[2].Width = 75;
            DGVSubject.Columns[3].Width = 75;
            //  DGVSubject.DataMember();
        }
    
    private void Addsubject_Load(object sender, EventArgs e)
        {
            LoadSerial();
           
        }
    }
}
