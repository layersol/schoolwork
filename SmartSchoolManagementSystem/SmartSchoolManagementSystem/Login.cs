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
    public partial class Login : Form
    {
        public delegate void SetParameterValueDelegate(string value);



        public Login()
        {
            InitializeComponent();
           
        }
        public static string SetValueForText = "";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            SetValueForText =txtuser.Text;
            MDIParent objopen = new MDIParent();
            // objopen.MdiParent = this;
            
            this.Hide();
            objopen.Show();
            MessageBox.Show("You Have been Successfully LoggedIn", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnlogin;
        }
    }
}
