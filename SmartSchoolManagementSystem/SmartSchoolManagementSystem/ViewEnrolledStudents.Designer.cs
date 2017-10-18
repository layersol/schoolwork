﻿namespace SmartSchoolManagementSystem
{
    partial class ViewEnrolledStudents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbsearchbysection = new System.Windows.Forms.ComboBox();
            this.cbbsearchbyclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkaddress = new System.Windows.Forms.CheckBox();
            this.chkphone = new System.Windows.Forms.CheckBox();
            this.chkdateofbirth = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgdview = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbbsearchbysection);
            this.panel1.Controls.Add(this.cbbsearchbyclass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(4, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbbsearchbysection
            // 
            this.cbbsearchbysection.FormattingEnabled = true;
            this.cbbsearchbysection.Location = new System.Drawing.Point(76, 52);
            this.cbbsearchbysection.Name = "cbbsearchbysection";
            this.cbbsearchbysection.Size = new System.Drawing.Size(209, 21);
            this.cbbsearchbysection.TabIndex = 1;
            // 
            // cbbsearchbyclass
            // 
            this.cbbsearchbyclass.FormattingEnabled = true;
            this.cbbsearchbyclass.Location = new System.Drawing.Point(76, 6);
            this.cbbsearchbyclass.Name = "cbbsearchbyclass";
            this.cbbsearchbyclass.Size = new System.Drawing.Size(209, 21);
            this.cbbsearchbyclass.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.chkaddress);
            this.groupBox1.Controls.Add(this.chkphone);
            this.groupBox1.Controls.Add(this.chkdateofbirth);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(4, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Show Options";
            // 
            // chkaddress
            // 
            this.chkaddress.AutoSize = true;
            this.chkaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkaddress.Location = new System.Drawing.Point(208, 42);
            this.chkaddress.Name = "chkaddress";
            this.chkaddress.Size = new System.Drawing.Size(86, 21);
            this.chkaddress.TabIndex = 0;
            this.chkaddress.Text = "Address";
            this.chkaddress.UseVisualStyleBackColor = true;
            // 
            // chkphone
            // 
            this.chkphone.AutoSize = true;
            this.chkphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkphone.Location = new System.Drawing.Point(127, 42);
            this.chkphone.Name = "chkphone";
            this.chkphone.Size = new System.Drawing.Size(73, 21);
            this.chkphone.TabIndex = 0;
            this.chkphone.Text = "Phone";
            this.chkphone.UseVisualStyleBackColor = true;
            // 
            // chkdateofbirth
            // 
            this.chkdateofbirth.AutoSize = true;
            this.chkdateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkdateofbirth.Location = new System.Drawing.Point(4, 42);
            this.chkdateofbirth.Name = "chkdateofbirth";
            this.chkdateofbirth.Size = new System.Drawing.Size(119, 21);
            this.chkdateofbirth.TabIndex = 0;
            this.chkdateofbirth.Text = "Date of Birth";
            this.chkdateofbirth.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btncancel);
            this.panel2.Controls.Add(this.btnview);
            this.panel2.Location = new System.Drawing.Point(4, 268);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 42);
            this.panel2.TabIndex = 2;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(144, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 29);
            this.btncancel.TabIndex = 0;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnview
            // 
            this.btnview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnview.Location = new System.Drawing.Point(63, 5);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 29);
            this.btnview.TabIndex = 0;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgdview);
            this.panel3.Location = new System.Drawing.Point(316, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(641, 255);
            this.panel3.TabIndex = 3;
            // 
            // dgdview
            // 
            this.dgdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdview.Location = new System.Drawing.Point(3, 2);
            this.dgdview.Name = "dgdview";
            this.dgdview.Size = new System.Drawing.Size(633, 248);
            this.dgdview.TabIndex = 0;
            this.dgdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(953, 47);
            this.panel4.TabIndex = 4;
            // 
            // ViewEnrolledStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 318);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewEnrolledStudents";
            this.Text = "View Enrolled Students";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbsearchbysection;
        private System.Windows.Forms.ComboBox cbbsearchbyclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkaddress;
        private System.Windows.Forms.CheckBox chkphone;
        private System.Windows.Forms.CheckBox chkdateofbirth;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgdview;
        private System.Windows.Forms.Panel panel4;
    }
}