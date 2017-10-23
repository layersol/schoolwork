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
        public Attendanceall()
        {
            InitializeComponent();
            Getdropdown();
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
                var Getgroup = (from a in db.Tblclasssections
                                    //where a.Class == cbbclass.SelectedItem.ToString()
                                select new { a.ID, Names = a.Group, }).ToList();

                cbbgroup.DataSource = Getgroup.ToList();
                cbbgroup.DisplayMember = "Names";
                cbbgroup.ValueMember = "ID";
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void btnsearch_Click(object sender, EventArgs e)
        {

        }
    }
}
