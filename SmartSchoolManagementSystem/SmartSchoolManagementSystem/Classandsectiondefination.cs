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
        public Classandsectiondefination()
        {
            InitializeComponent();
        }
        private void Getclass()
        { var qaNames = (from a in db.Tblclasses
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
        }
    }
}
