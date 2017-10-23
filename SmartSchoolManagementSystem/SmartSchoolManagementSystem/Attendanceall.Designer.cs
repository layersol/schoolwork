namespace SmartSchoolManagementSystem
{
    partial class Attendanceall
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbclass = new System.Windows.Forms.ComboBox();
            this.cbbsection = new System.Windows.Forms.ComboBox();
            this.cbbgroup = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsearch);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.cbbgroup);
            this.groupBox1.Controls.Add(this.cbbsection);
            this.groupBox1.Controls.Add(this.cbbclass);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1191, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(9, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1191, 393);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // cbbclass
            // 
            this.cbbclass.FormattingEnabled = true;
            this.cbbclass.Location = new System.Drawing.Point(96, 20);
            this.cbbclass.Name = "cbbclass";
            this.cbbclass.Size = new System.Drawing.Size(121, 21);
            this.cbbclass.TabIndex = 0;
            // 
            // cbbsection
            // 
            this.cbbsection.FormattingEnabled = true;
            this.cbbsection.Location = new System.Drawing.Point(223, 19);
            this.cbbsection.Name = "cbbsection";
            this.cbbsection.Size = new System.Drawing.Size(121, 21);
            this.cbbsection.TabIndex = 1;
            // 
            // cbbgroup
            // 
            this.cbbgroup.FormattingEnabled = true;
            this.cbbgroup.Location = new System.Drawing.Point(350, 19);
            this.cbbgroup.Name = "cbbgroup";
            this.cbbgroup.Size = new System.Drawing.Size(121, 21);
            this.cbbgroup.TabIndex = 2;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(477, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 3;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(614, 17);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 4;
            this.btnsearch.Text = "button1";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Attendanceall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 481);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Attendanceall";
            this.Text = "Attendanceall";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbclass;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox cbbgroup;
        private System.Windows.Forms.ComboBox cbbsection;
        private System.Windows.Forms.Button btnsearch;
    }
}