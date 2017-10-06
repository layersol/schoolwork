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
    public partial class Add_Class_Section : Form
    {
        smartschooldbEntities1 db = new smartschooldbEntities1();
        public Add_Class_Section()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            Tblclass content = new Tblclass();
            content.CLASSNAME = txtclass.Text;
            db.Tblclasses.Add(content);
            db.SaveChanges();
            MessageBox.Show("your class has been successfully Add");
            
        }

        

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
