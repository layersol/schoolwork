namespace SmartSchoolManagementSystem
{
    partial class ViewAttendance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbblankregister = new System.Windows.Forms.RadioButton();
            this.rdbclass = new System.Windows.Forms.RadioButton();
            this.rdbstudent = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbfeemonth = new System.Windows.Forms.ComboBox();
            this.txtsection = new System.Windows.Forms.TextBox();
            this.txtclass = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnpreview = new System.Windows.Forms.Button();
            this.btnprint = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.rdbblankregister);
            this.groupBox1.Controls.Add(this.rdbclass);
            this.groupBox1.Controls.Add(this.rdbstudent);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Mode";
            // 
            // rdbblankregister
            // 
            this.rdbblankregister.AutoSize = true;
            this.rdbblankregister.Location = new System.Drawing.Point(189, 36);
            this.rdbblankregister.Name = "rdbblankregister";
            this.rdbblankregister.Size = new System.Drawing.Size(132, 21);
            this.rdbblankregister.TabIndex = 0;
            this.rdbblankregister.TabStop = true;
            this.rdbblankregister.Text = "Blank Register";
            this.rdbblankregister.UseVisualStyleBackColor = true;
            // 
            // rdbclass
            // 
            this.rdbclass.AutoSize = true;
            this.rdbclass.Location = new System.Drawing.Point(109, 36);
            this.rdbclass.Name = "rdbclass";
            this.rdbclass.Size = new System.Drawing.Size(65, 21);
            this.rdbclass.TabIndex = 0;
            this.rdbclass.TabStop = true;
            this.rdbclass.Text = "Class";
            this.rdbclass.UseVisualStyleBackColor = true;
            // 
            // rdbstudent
            // 
            this.rdbstudent.AutoSize = true;
            this.rdbstudent.Location = new System.Drawing.Point(10, 36);
            this.rdbstudent.Name = "rdbstudent";
            this.rdbstudent.Size = new System.Drawing.Size(82, 21);
            this.rdbstudent.TabIndex = 0;
            this.rdbstudent.TabStop = true;
            this.rdbstudent.Text = "Student";
            this.rdbstudent.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::SmartSchoolManagementSystem.Properties.Resources.stdv;
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 42);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.cbbfeemonth);
            this.panel2.Controls.Add(this.txtsection);
            this.panel2.Controls.Add(this.txtclass);
            this.panel2.Controls.Add(this.txtyear);
            this.panel2.Controls.Add(this.txtstudentid);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(4, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 163);
            this.panel2.TabIndex = 2;
            // 
            // cbbfeemonth
            // 
            this.cbbfeemonth.FormattingEnabled = true;
            this.cbbfeemonth.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March",
            "April ",
            "May ",
            "June",
            "July",
            "August ",
            "September",
            "October ",
            "November ",
            "December"});
            this.cbbfeemonth.Location = new System.Drawing.Point(108, 42);
            this.cbbfeemonth.Name = "cbbfeemonth";
            this.cbbfeemonth.Size = new System.Drawing.Size(212, 21);
            this.cbbfeemonth.TabIndex = 2;
            // 
            // txtsection
            // 
            this.txtsection.Location = new System.Drawing.Point(108, 122);
            this.txtsection.Name = "txtsection";
            this.txtsection.Size = new System.Drawing.Size(212, 20);
            this.txtsection.TabIndex = 1;
            // 
            // txtclass
            // 
            this.txtclass.Location = new System.Drawing.Point(108, 92);
            this.txtclass.Name = "txtclass";
            this.txtclass.Size = new System.Drawing.Size(212, 20);
            this.txtclass.TabIndex = 1;
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(108, 66);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(212, 20);
            this.txtyear.TabIndex = 1;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(108, 15);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(212, 20);
            this.txtstudentid.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fee Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Id";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.btnpreview);
            this.panel3.Controls.Add(this.btnprint);
            this.panel3.Controls.Add(this.btnview);
            this.panel3.Location = new System.Drawing.Point(3, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 49);
            this.panel3.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(227, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 33);
            this.button4.TabIndex = 1;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.Location = new System.Drawing.Point(132, 8);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(94, 33);
            this.btnpreview.TabIndex = 1;
            this.btnpreview.Text = "Preview";
            this.btnpreview.UseVisualStyleBackColor = false;
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnprint.Image = global::SmartSchoolManagementSystem.Properties.Resources.Printer_icon;
            this.btnprint.Location = new System.Drawing.Point(55, 8);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(49, 33);
            this.btnprint.TabIndex = 0;
            this.btnprint.UseVisualStyleBackColor = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnview.Image = global::SmartSchoolManagementSystem.Properties.Resources.view2;
            this.btnview.Location = new System.Drawing.Point(3, 8);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(49, 33);
            this.btnview.TabIndex = 0;
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // ViewAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 363);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ViewAttendance";
            this.Text = "View Attendance";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbblankregister;
        private System.Windows.Forms.RadioButton rdbclass;
        private System.Windows.Forms.RadioButton rdbstudent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsection;
        private System.Windows.Forms.TextBox txtclass;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.ComboBox cbbfeemonth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnprint;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnpreview;
    }
}