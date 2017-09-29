using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class TeachersttafInformation : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string imgloc = "";
        public TeachersttafInformation()
        {
            InitializeComponent();
        }
        private byte[] convertfiletobyte(string sPath)
        {
            byte[] data = null;
            FileInfo finfo = new FileInfo(sPath);
            long numBytes = finfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            return data;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {

                if (txttname.Text != "" && txtfname.Text != "" && txtaddress.Text != "")
                {
                    TblTeacherInformation objinsert = new TblTeacherInformation();
            objinsert.TEACHERNAME = txttname.Text;
            objinsert.JOININGDATE = Convert.ToDateTime(txtdtp.Text);
            objinsert.FATHERNAME = txtfname.Text;
            objinsert.CELLNO =Convert.ToDecimal(txtcellNo.Text);
            objinsert.OTHERCONTACT = Convert.ToDecimal(txtotherno.Text);
                    objinsert.GENDER = combgender.SelectedItem.ToString();
            objinsert.SALAR = txtsalary.Text;
            objinsert.DOB = Convert.ToDateTime(dobdtpp.Text);
            objinsert.QUALIFICATION = txtqualification.Text;
            objinsert.POSITION = txtposition.Text;
            objinsert.TEACHINGEXP = txtexprience.Text;
            objinsert.ADDRESS = txtaddress.Text;
            objinsert.COMMENTS = txtcomments.Text;
                    objinsert.TeachImage= convertfiletobyte(this.imgpicturebox.ImageLocation);
                    if (cbstatus.Checked==true)
            { objinsert.STATUS = true; }
            else { objinsert.STATUS = false; }
            db.TblTeacherInformations.Add(objinsert);
            db.SaveChanges();
                    MessageBox.Show("Information Saved Successfully!");
                }
                else
                {
                    DialogResult result2 = MessageBox.Show("Please Fill All Field!", "Field Required", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                }
            }
            catch { MessageBox.Show("Somthing Wrong!"); }
        }

        private void txttname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txttname.Text = textInfo.ToTitleCase(txttname.Text);
            txttname.Select(txttname.Text.Length, 1);
        }

        private void txtfname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtfname.Text = textInfo.ToTitleCase(txtfname.Text);
            txtfname.Select(txtfname.Text.Length, 1);
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtaddress.Text = textInfo.ToTitleCase(txtaddress.Text);
            txtaddress.Select(txtaddress.Text.Length, 1);
        }

        private void txtcomments_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtcomments.Text = textInfo.ToTitleCase(txtcomments.Text);
            txtcomments.Select(txtcomments.Text.Length, 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void imgbtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    imgloc = dlg.FileName.ToString();
                    imgpicturebox.ImageLocation = imgloc;
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
