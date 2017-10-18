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
        smartschooldbEntities db = new smartschooldbEntities();
        public delegate void SetParameterValueDelegate(string value);



        public Login()
        {
            InitializeComponent();
           
        }
        public static string SetValueForText = "";
        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {
                var q = (from a in db.TBLUSERs
                      //   where a.LastName == txtuser.Text
                         select a).SingleOrDefault();
                string password = q.Password;
                string user = q.LastName;

                if (user==txtuser.Text)  //if record exis in db , it will return true, otherwise it will return false  
                {
                    if (Cryptography.Decrypt(password).Equals(txtPassword.Text))
                    {
                       // MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //  Form1 frm1 = new Form1();
                        //   frm1.ShowDialog();

                        SetValueForText = txtuser.Text;
                        MDIParent objopen = new MDIParent();
                        // objopen.MdiParent = this;

                        this.Hide();
                        objopen.Show();

                    }
                    else
                    {
                        MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else  //showing the error message if user credential is wrong  
                {
                    MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }



           
            

        }
        private bool IsvalidUser(string userName)
        {

           
            var q = from p in db.TBLUSERs
                    where p.LastName == txtPassword.Text
                  //  && p.Password == txtPassw.Text
                    select p.Password;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
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
