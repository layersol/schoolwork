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
    public partial class CreateNEWUser : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public CreateNEWUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtusername.Text != "" && txtpassword.Text != "" && txtrepassword.Text != "")  //validating the fields whether the fields or empty or not  
            {
                if (txtpassword.Text.ToString().Trim().ToLower() == txtrepassword.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    string UserName = txtusername.Text;
                    string Password = Cryptography.Encrypt(txtpassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    TBLUSER con = new TBLUSER();
                    con.FirstName = txtname.Text;
                    con.LastName = UserName;
                    con.Password = Password;
                    con.UserType = txttype.Text;
                    con.RegDate = System.DateTime.Now;
                    con.Email = txtemail.Text;
                    db.TBLUSERs.Add(con);
                    db.SaveChanges();
                   
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
