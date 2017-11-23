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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbmedium = new System.Windows.Forms.ComboBox();
            this.cbbgroup = new System.Windows.Forms.ComboBox();
            this.cbbsection = new System.Windows.Forms.ComboBox();
            this.cbbclass = new System.Windows.Forms.ComboBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btngap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvattendace = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendace)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbmedium);
            this.groupBox2.Controls.Add(this.cbbgroup);
            this.groupBox2.Controls.Add(this.cbbsection);
            this.groupBox2.Controls.Add(this.cbbclass);
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.btngap);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 421);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Medium";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Group";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Class";
            // 
            // cbbmedium
            // 
            this.cbbmedium.FormattingEnabled = true;
            this.cbbmedium.Location = new System.Drawing.Point(77, 100);
            this.cbbmedium.Name = "cbbmedium";
            this.cbbmedium.Size = new System.Drawing.Size(135, 21);
            this.cbbmedium.TabIndex = 17;
            // 
            // cbbgroup
            // 
            this.cbbgroup.FormattingEnabled = true;
            this.cbbgroup.Location = new System.Drawing.Point(77, 73);
            this.cbbgroup.Name = "cbbgroup";
            this.cbbgroup.Size = new System.Drawing.Size(135, 21);
            this.cbbgroup.TabIndex = 16;
            // 
            // cbbsection
            // 
            this.cbbsection.FormattingEnabled = true;
            this.cbbsection.Location = new System.Drawing.Point(77, 43);
            this.cbbsection.Name = "cbbsection";
            this.cbbsection.Size = new System.Drawing.Size(135, 21);
            this.cbbsection.TabIndex = 15;
            // 
            // cbbclass
            // 
            this.cbbclass.FormattingEnabled = true;
            this.cbbclass.Location = new System.Drawing.Point(77, 16);
            this.cbbclass.Name = "cbbclass";
            this.cbbclass.Size = new System.Drawing.Size(135, 21);
            this.cbbclass.TabIndex = 14;
            this.cbbclass.SelectedValueChanged += new System.EventHandler(this.cbbclass_SelectedValueChanged);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsearch.ForeColor = System.Drawing.Color.Red;
            this.btnsearch.Location = new System.Drawing.Point(77, 127);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(135, 39);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click_1);
            // 
            // btngap
            // 
            this.btngap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btngap.Location = new System.Drawing.Point(77, 172);
            this.btngap.Name = "btngap";
            this.btngap.Size = new System.Drawing.Size(135, 36);
            this.btngap.TabIndex = 13;
            this.btngap.Text = "Go All Present";
            this.btngap.UseVisualStyleBackColor = false;
            this.btngap.Click += new System.EventHandler(this.btngap_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvattendace);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 427);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // dgvattendace
            // 
            this.dgvattendace.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvattendace.Location = new System.Drawing.Point(6, 16);
            this.dgvattendace.Name = "dgvattendace";
            this.dgvattendace.Size = new System.Drawing.Size(998, 405);
            this.dgvattendace.TabIndex = 0;
            // 
            // Attendanceall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 440);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Attendanceall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendanceall";
            this.Load += new System.EventHandler(this.Attendanceall_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbmedium;
        private System.Windows.Forms.ComboBox cbbgroup;
        private System.Windows.Forms.ComboBox cbbsection;
        private System.Windows.Forms.ComboBox cbbclass;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btngap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvattendace;
    }
}