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
    public partial class testform : Form
    {
        smartschooldbEntities1 db = new smartschooldbEntities1();
        public testform()
        {
            InitializeComponent();
        }

        private void testform_Load(object sender, EventArgs e)
        {
            //DataGrid dataGrid1 = new DataGrid();
            //DataGrid dataGrid2 = new DataGrid();
            //DataGrid dataGrid3 = new DataGrid();

            //var custQuery =
            //    from cust in db.Tblclasses
            //    select cust;
            //dataGrid1.DataSource = custQuery;
            //dataGrid2.DataSource = custQuery;
            //dataGrid2.DataMember = "Orders";

            //BindingSource bs = new BindingSource();
            //bs.DataSource = custQuery;
            //dataGrid3.DataSource = bs;
        }
    }
}
