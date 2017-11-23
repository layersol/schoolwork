namespace SmartSchoolManagementSystem
{
    partial class Addbussstops
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
            this.cbbstops = new System.Windows.Forms.ComboBox();
            this.cbbdestination = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.cbbstops);
            this.groupBox1.Controls.Add(this.cbbdestination);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add bus information";
            // 
            // cbbstops
            // 
            this.cbbstops.FormattingEnabled = true;
            this.cbbstops.Location = new System.Drawing.Point(66, 78);
            this.cbbstops.Name = "cbbstops";
            this.cbbstops.Size = new System.Drawing.Size(159, 21);
            this.cbbstops.TabIndex = 32;
            // 
            // cbbdestination
            // 
            this.cbbdestination.FormattingEnabled = true;
            this.cbbdestination.Location = new System.Drawing.Point(66, 49);
            this.cbbdestination.Name = "cbbdestination";
            this.cbbdestination.Size = new System.Drawing.Size(159, 21);
            this.cbbdestination.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Stop ";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(66, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(159, 21);
            this.comboBox4.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Bus ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Destination";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(264, 119);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnnew);
            this.panel1.Controls.Add(this.btnupdate);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Location = new System.Drawing.Point(2, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 72);
            this.panel1.TabIndex = 2;
            // 
            // btnnew
            // 
            this.btnnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Image = global::SmartSchoolManagementSystem.Properties.Resources.addblue;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(12, 16);
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
            this.btnupdate.Location = new System.Drawing.Point(187, 16);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(95, 38);
            this.btnupdate.TabIndex = 14;
            this.btnupdate.Text = "Update";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Image = global::SmartSchoolManagementSystem.Properties.Resources.close;
            this.btnclose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclose.Location = new System.Drawing.Point(288, 17);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(88, 38);
            this.btnclose.TabIndex = 16;
            this.btnclose.Text = "Close";
            this.btnclose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::SmartSchoolManagementSystem.Properties.Resources.save;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(90, 17);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(91, 36);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Save";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = false;
            // 
            // Addbussstops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 250);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Addbussstops";
            this.Text = "Addbussstops";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbstops;
        private System.Windows.Forms.ComboBox cbbdestination;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnsave;
    }
}