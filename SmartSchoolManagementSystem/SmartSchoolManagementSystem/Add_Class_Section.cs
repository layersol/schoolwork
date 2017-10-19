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
    public partial class Add_Class : Form
    {
        smartschooldbEntities db = new smartschooldbEntities();
        string dgv;
        int dgva = 0;
        public Add_Class()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                var alreadyInDb = (from p in db.Tblclasses where p.CLASSNAME == txtclass.Text select p).Count() > 0;

                if (alreadyInDb == false)
                {
                    Tblclass content = new Tblclass();
                    content.CLASSNAME = txtclass.Text;
                    db.Tblclasses.Add(content);
                    db.SaveChanges();
                    MessageBox.Show("your class has been successfully Add");
                }
                else { MessageBox.Show("This Class Already exist"); }
                loadclass();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Database connection Error"); }
        }

        

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                Tblclass product = db.Tblclasses.Single(p => p.ID == dgva);


                if (product != null)
                {
                    product.CLASSNAME = txtclass.Text;

                    db.SaveChanges();
                    MessageBox.Show("Section Updated", "Attention");
                }
                loadclass();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void loadclass()
        {
            try
            {
                var Getclass = db.Tblclasses.ToList();
                DGVclass.DataSource = Getclass.ToList();
                DataGridViewColumn column = DGVclass.Columns[0];
                column.Width = 60;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Database connection Error"); }
        }
        private void Add_Class_Load(object sender, EventArgs e)
        {
            loadclass();
        }

        private void txtclass_TextChanged(object sender, EventArgs e)
        {
            CultureInfo cI = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cI.TextInfo;
            txtclass.Text = textInfo.ToTitleCase(txtclass.Text);
            txtclass.Select(txtclass.Text.Length, 1);
        }

        private void DGVclass_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.DGVclass.Rows[e.RowIndex];
                    if (row != null)
                        dgv = row.Cells["ID"].Value.ToString();
                    dgva = Convert.ToInt16(dgv);

                    txtclass.Text = row.Cells["CLASSNAME"].Value.ToString();
                }
            }
            catch(Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
