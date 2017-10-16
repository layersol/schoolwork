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
    public partial class RegisterNewUser : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        public RegisterNewUser()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtfname.Text != "" && txtpass.Text != "" && txtrepass.Text != "")  //validating the fields whether the fields or empty or not  
            {
                if (txtpass.Text.ToString().Trim().ToLower() == txtrepass.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    string UserName = txtfname.Text;
                    string Password = Cryptography.Encrypt(txtpass.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    TBLUSER content = new TBLUSER();
                    content.FirstName = UserName;
                    content.LastName = txtlname.Text;
                    content.UserType = cbbusertype.Text;
                    content.RegDate = System.DateTime.Now;
                    content.Email = txtemail.Text;
                    content.Password = Password;
                    if (cbstatus.Checked==true)
                    { content.Status = true; }
                    else { content.Status = false; }
                    db.TBLUSERs.Add(content);
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
    }
}
