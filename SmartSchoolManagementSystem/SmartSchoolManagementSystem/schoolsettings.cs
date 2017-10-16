using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class schoolsettings : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string imgloc = "";
        int PID;
        public schoolsettings()
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
        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {


                if (txtname.Text != "" && txtcontacta.Text != "" && txtcontactb.Text != "")
                {
                    MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo);
                    Tblschoolsetting objcontext = new Tblschoolsetting();
                    objcontext.SchoolName = txtname.Text;
                    objcontext.CONTACTA = txtcontacta.Text;
                    objcontext.CONTACTB = txtcontactb.Text;
                    objcontext.CONTACTC = txtcontactb.Text;
                    objcontext.FIRSTEMAIL = txtemail.Text;
                    objcontext.SECONDEMAIL = txtemail.Text;
                    objcontext.WEBSITE = txtwebsite.Text;
                    objcontext.FIRSTADDRESS = addressa.Text;
                    objcontext.SECONDADDRESS = txtaddressb.Text;
                    objcontext.COMMENTS = txtcommnets.Text;
                    objcontext.LOGO = convertfiletobyte(this.imgpicturebox.ImageLocation);

                    db.Tblschoolsettings.Add(objcontext);
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

        private void btnbrowse_Click(object sender, EventArgs e)
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

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtname.Text = textInfo.ToTitleCase(txtname.Text);
            txtname.Select(txtname.Text.Length, 1);
        }

        private void addressa_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            addressa.Text = textInfo.ToTitleCase(addressa.Text);
            addressa.Select(addressa.Text.Length, 1);
        }

        private void txtaddressb_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtaddressb.Text = textInfo.ToTitleCase(txtaddressb.Text);
            txtaddressb.Select(txtaddressb.Text.Length, 1);
        }

        private void txtcommnets_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtcommnets.Text = textInfo.ToTitleCase(txtcommnets.Text);
            txtcommnets.Select(txtcommnets.Text.Length, 1);
        }

        private void txtcontacta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void txtcontactb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        private void btnview_Click(object sender, EventArgs e)
        {
            try
            {
              
                var q = (from a in db.Tblschoolsettings
                         where a.ID == 1
                         select a).SingleOrDefault();
                PID = q.ID;
                txtname.Text = q.SchoolName;

                txtcontacta.Text = q.CONTACTA;
                txtcontactb.Text = q.CONTACTB;
                txtcontactb.Text = q.CONTACTC;
                txtemail.Text = q.FIRSTEMAIL;
                txtemail.Text = q.SECONDEMAIL;
                txtwebsite.Text = q.WEBSITE;
                addressa.Text = q.FIRSTADDRESS;
                txtaddressb.Text = q.SECONDADDRESS;
                txtcommnets.Text = q.COMMENTS;
                // imgpicturebox.ImageLocation =Convert.ToString(q.LOGO);
                if (q != null)
                {
                    using (var ms = new MemoryStream(q.LOGO))
                    {
                        using (var image = Image.FromStream(ms))
                        {
                            imgpicturebox.Image = (Image)image.Clone();
                           
                        }
                    }
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //decimal val = Convert.ToInt16(cbitem.SelectedValue);
            //var val2 = (from u in db.tblstockins where u.PID == PID select u).Count() > 0;
            //if (val2 != false)
            //{
            try
            {
                MemoryStream ms = new MemoryStream();
                imgpicturebox.Image.Save(ms, imgpicturebox.Image.RawFormat);
                byte[] img = ms.ToArray();

                Tblschoolsetting product = db.Tblschoolsettings.Single(p => p.ID == PID);


                    if (product != null)
                    {
                        product.SchoolName = txtname.Text;
                        product.CONTACTA = txtcontacta.Text;
                        product.CONTACTB = txtcontactb.Text;
                        product.CONTACTC = txtcontactb.Text;
                        product.FIRSTEMAIL = txtemail.Text;
                        product.SECONDEMAIL = txtemail.Text;
                        product.WEBSITE = txtwebsite.Text;
                        product.FIRSTADDRESS = addressa.Text;
                        product.SECONDADDRESS = txtaddressb.Text;
                        product.COMMENTS = txtcommnets.Text;
                        product.LOGO = img;
                        db.SaveChanges();
                        MessageBox.Show("Updated", "Attention");
                    }
               
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void schoolsettings_Load(object sender, EventArgs e)
        {
            try
            {
                var val = db.Tblschoolsettings.ToList();
                if (val!=null)
                {
                    btnsave.Enabled = true;
                    
                }
                else
                { this.btnsave.Enabled = false;

                }
                this.Refresh();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}