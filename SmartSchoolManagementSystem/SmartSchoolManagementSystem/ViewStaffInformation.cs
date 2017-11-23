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
    public partial class ViewStaffInformation : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public ViewStaffInformation()
        {
            InitializeComponent();
        }

        private void ViewStaffInformation_Load(object sender, EventArgs e)
        {
            try {
                var viewstaff = from a in db.TblTeacherInformations
                                select new
                                {
                                    ID = a.ID,
                                    Name = a.TEACHERNAME,
                                    Position=a.POSITION,
                                    Contact=a.CELLNO,
                                    Gender=a.GENDER,
                                    Salary=a.SALAR,
                                };
                  
                dgdview.DataSource = viewstaff.ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
