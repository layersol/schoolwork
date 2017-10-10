namespace SmartSchoolManagementSystem
{
    partial class ExpencesRecord
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtexpencid = new System.Windows.Forms.TextBox();
            this.txtdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbexpencename = new System.Windows.Forms.ComboBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtamount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtexpenceby = new System.Windows.Forms.TextBox();
            this.txtcreationdate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcreatedby = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtupdatedby = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtupdationdate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnclose = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnid = new System.Windows.Forms.Button();
            this.btnexpencedescription = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(191, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "EXPENC RECORD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtdescription);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cbbexpencename);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtexpenceby);
            this.panel2.Controls.Add(this.txtdate);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtamount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtexpencid);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(5, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 138);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtupdatedby);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtupdationdate);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtcreatedby);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtcreationdate);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(5, 216);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(387, 120);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expence ID";
            // 
            // txtexpencid
            // 
            this.txtexpencid.Location = new System.Drawing.Point(97, 7);
            this.txtexpencid.Name = "txtexpencid";
            this.txtexpencid.Size = new System.Drawing.Size(71, 20);
            this.txtexpencid.TabIndex = 1;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(233, 8);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(145, 20);
            this.txtdate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Expence Name";
            // 
            // cbbexpencename
            // 
            this.cbbexpencename.FormattingEnabled = true;
            this.cbbexpencename.Location = new System.Drawing.Point(97, 37);
            this.cbbexpencename.Name = "cbbexpencename";
            this.cbbexpencename.Size = new System.Drawing.Size(281, 21);
            this.cbbexpencename.TabIndex = 5;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(97, 64);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(281, 20);
            this.txtdescription.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(97, 90);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(71, 20);
            this.txtamount.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(171, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Expence By";
            // 
            // txtexpenceby
            // 
            this.txtexpenceby.Location = new System.Drawing.Point(233, 91);
            this.txtexpenceby.Name = "txtexpenceby";
            this.txtexpenceby.Size = new System.Drawing.Size(145, 20);
            this.txtexpenceby.TabIndex = 3;
            // 
            // txtcreationdate
            // 
            this.txtcreationdate.Enabled = false;
            this.txtcreationdate.Location = new System.Drawing.Point(91, 32);
            this.txtcreationdate.Name = "txtcreationdate";
            this.txtcreationdate.Size = new System.Drawing.Size(281, 20);
            this.txtcreationdate.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Creation Date";
            // 
            // txtcreatedby
            // 
            this.txtcreatedby.Enabled = false;
            this.txtcreatedby.Location = new System.Drawing.Point(91, 6);
            this.txtcreatedby.Name = "txtcreatedby";
            this.txtcreatedby.Size = new System.Drawing.Size(281, 20);
            this.txtcreatedby.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Created By";
            // 
            // txtupdatedby
            // 
            this.txtupdatedby.Enabled = false;
            this.txtupdatedby.Location = new System.Drawing.Point(91, 58);
            this.txtupdatedby.Name = "txtupdatedby";
            this.txtupdatedby.Size = new System.Drawing.Size(281, 20);
            this.txtupdatedby.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Updated By";
            // 
            // txtupdationdate
            // 
            this.txtupdationdate.Enabled = false;
            this.txtupdationdate.Location = new System.Drawing.Point(91, 84);
            this.txtupdationdate.Name = "txtupdationdate";
            this.txtupdationdate.Size = new System.Drawing.Size(281, 20);
            this.txtupdationdate.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Updation Date";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnexpencedescription);
            this.panel4.Controls.Add(this.btnid);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(396, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(199, 263);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnclose);
            this.panel5.Controls.Add(this.btncancel);
            this.panel5.Controls.Add(this.btnsave);
            this.panel5.Controls.Add(this.btnadd);
            this.panel5.Location = new System.Drawing.Point(5, 343);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(592, 64);
            this.panel5.TabIndex = 4;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(315, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(94, 38);
            this.btnclose.TabIndex = 19;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncancel.Location = new System.Drawing.Point(215, 12);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(94, 38);
            this.btncancel.TabIndex = 18;
            this.btncancel.Text = "Cancel";
            this.btncancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(115, 12);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 38);
            this.btnsave.TabIndex = 16;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnadd.Location = new System.Drawing.Point(15, 12);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(94, 38);
            this.btnadd.TabIndex = 15;
            this.btnadd.Text = "Add";
            this.btnadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnadd.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(191, 228);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnid
            // 
            this.btnid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnid.Location = new System.Drawing.Point(3, 2);
            this.btnid.Name = "btnid";
            this.btnid.Size = new System.Drawing.Size(32, 23);
            this.btnid.TabIndex = 1;
            this.btnid.Text = "ID";
            this.btnid.UseVisualStyleBackColor = false;
            // 
            // btnexpencedescription
            // 
            this.btnexpencedescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnexpencedescription.Location = new System.Drawing.Point(44, 2);
            this.btnexpencedescription.Name = "btnexpencedescription";
            this.btnexpencedescription.Size = new System.Drawing.Size(150, 23);
            this.btnexpencedescription.TabIndex = 1;
            this.btnexpencedescription.Text = "Expence Descrition";
            this.btnexpencedescription.UseVisualStyleBackColor = false;
            // 
            // ExpencesRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 411);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ExpencesRecord";
            this.Text = "ExpencesRecord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtexpencid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbexpencename;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtexpenceby;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtamount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtupdatedby;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtupdationdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcreatedby;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcreationdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnexpencedescription;
        private System.Windows.Forms.Button btnid;
    }
}