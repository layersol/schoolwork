namespace SmartSchoolManagementSystem
{
    partial class Addsubject
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsubname = new System.Windows.Forms.TextBox();
            this.txttotalmrks = new System.Windows.Forms.TextBox();
            this.txtpassing = new System.Windows.Forms.TextBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DGVSubject = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 45);
            this.panel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtpassing);
            this.groupBox1.Controls.Add(this.txttotalmrks);
            this.groupBox1.Controls.Add(this.txtsubname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Subject Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Passing Marks";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Subject Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Total Marks";
            // 
            // txtsubname
            // 
            this.txtsubname.Location = new System.Drawing.Point(100, 23);
            this.txtsubname.Name = "txtsubname";
            this.txtsubname.Size = new System.Drawing.Size(202, 20);
            this.txtsubname.TabIndex = 30;
            // 
            // txttotalmrks
            // 
            this.txttotalmrks.Location = new System.Drawing.Point(100, 50);
            this.txttotalmrks.Name = "txttotalmrks";
            this.txttotalmrks.Size = new System.Drawing.Size(202, 20);
            this.txttotalmrks.TabIndex = 31;
            // 
            // txtpassing
            // 
            this.txtpassing.Location = new System.Drawing.Point(100, 77);
            this.txtpassing.Name = "txtpassing";
            this.txtpassing.Size = new System.Drawing.Size(202, 20);
            this.txtpassing.TabIndex = 32;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Image = global::SmartSchoolManagementSystem.Properties.Resources.addblue;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(12, 3);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(72, 37);
            this.btnnew.TabIndex = 17;
            this.btnnew.Text = "Add";
            this.btnnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnnew.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Image = global::SmartSchoolManagementSystem.Properties.Resources.Update;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(187, 3);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 38);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::SmartSchoolManagementSystem.Properties.Resources.save;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(90, 4);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 36);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGVSubject);
            this.groupBox2.Location = new System.Drawing.Point(308, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 159);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // DGVSubject
            // 
            this.DGVSubject.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DGVSubject.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGVSubject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVSubject.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.DGVSubject.Location = new System.Drawing.Point(0, 6);
            this.DGVSubject.Name = "DGVSubject";
            this.DGVSubject.Size = new System.Drawing.Size(357, 150);
            this.DGVSubject.TabIndex = 0;
            // 
            // Addsubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 169);
            this.Controls.Add(this.groupBox1);
            this.Name = "Addsubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subject";
            this.Load += new System.EventHandler(this.Addsubject_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVSubject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassing;
        private System.Windows.Forms.TextBox txttotalmrks;
        private System.Windows.Forms.TextBox txtsubname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView DGVSubject;
    }
}