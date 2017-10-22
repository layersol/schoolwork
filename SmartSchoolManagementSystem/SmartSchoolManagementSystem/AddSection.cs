using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem
{
    public partial class AddSection : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string dgv;
        int dgva=0;
        public AddSection()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
               // TblSection product = db.TblSections.Single(p => p.Section == txtsection.Text);
                var alreadyInDb = (from p in db.TblSections where p.Section == txtsection.Text select p).Count() > 0;

                if (alreadyInDb==false)
                {
                    TblSection content = new TblSection();
                    content.Section = txtsection.Text;
                    db.TblSections.Add(content);
                    db.SaveChanges();
                    MessageBox.Show("your Section has been successfully Add");
                }
                else { MessageBox.Show("This Section Already exist"); }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Database connection Error"); }
        }
          private void loadsection()
        {
            try
            {
                var Getclass = db.TblSections.ToList();
            DGVclass.DataSource = Getclass.ToList();
            DataGridViewColumn column = DGVclass.Columns[0];
            column.Width = 30;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Database connection Error"); }
        }
        private void AddSection_Load(object sender, EventArgs e)
        {
            
                loadsection();
           
        }

        private void DGVclass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DGVclass.Rows[e.RowIndex];
                if (row != null)
                    dgv = row.Cells["ID"].Value.ToString();
                 dgva = Convert.ToInt16(dgv);

                txtsection.Text = row.Cells["section"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                TblSection product = db.TblSections.Single(p => p.ID ==dgva);


                if (product != null)
                {
                    product.Section = txtsection.Text;
                   
                    db.SaveChanges();
                    MessageBox.Show("Section Updated", "Attention");
                }
                loadsection();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtsection_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtsection.Text = textInfo.ToTitleCase(txtsection.Text);
            txtsection.Select(txtsection.Text.Length, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}