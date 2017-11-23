namespace SmartSchoolManagementSystem
{
    partial class StudentIdCardForm
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
            this.cbbsection = new System.Windows.Forms.ComboBox();
            this.cbbclass = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnidpreview = new System.Windows.Forms.Button();
            this.btnidprint = new System.Windows.Forms.Button();
            this.btnidview = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbbmedium = new System.Windows.Forms.ComboBox();
            this.cbbgroup = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.cbbmedium);
            this.panel1.Controls.Add(this.cbbgroup);
            this.panel1.Controls.Add(this.cbbsection);
            this.panel1.Controls.Add(this.cbbclass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 122);
            this.panel1.TabIndex = 0;
            // 
            // cbbsection
            // 
            this.cbbsection.FormattingEnabled = true;
            this.cbbsection.Location = new System.Drawing.Point(81, 32);
            this.cbbsection.Name = "cbbsection";
            this.cbbsection.Size = new System.Drawing.Size(229, 21);
            this.cbbsection.TabIndex = 1;
            // 
            // cbbclass
            // 
            this.cbbclass.FormattingEnabled = true;
            this.cbbclass.Location = new System.Drawing.Point(81, 6);
            this.cbbclass.Name = "cbbclass";
            this.cbbclass.Size = new System.Drawing.Size(229, 21);
            this.cbbclass.TabIndex = 1;
            this.cbbclass.SelectedValueChanged += new System.EventHandler(this.cbbclass_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Section";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.btnidpreview);
            this.groupBox1.Controls.Add(this.btnidprint);
            this.groupBox1.Controls.Add(this.btnidview);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(2, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report Mode";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(222, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 35);
            this.button4.TabIndex = 0;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnidpreview
            // 
            this.btnidpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnidpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnidpreview.Location = new System.Drawing.Point(131, 19);
            this.btnidpreview.Name = "btnidpreview";
            this.btnidpreview.Size = new System.Drawing.Size(89, 35);
            this.btnidpreview.TabIndex = 0;
            this.btnidpreview.Text = "Preview";
            this.btnidpreview.UseVisualStyleBackColor = false;
            // 
            // btnidprint
            // 
            this.btnidprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnidprint.Image = global::SmartSchoolManagementSystem.Properties.Resources.Printer_icon;
            this.btnidprint.Location = new System.Drawing.Point(71, 19);
            this.btnidprint.Name = "btnidprint";
            this.btnidprint.Size = new System.Drawing.Size(54, 35);
            this.btnidprint.TabIndex = 0;
            this.btnidprint.UseVisualStyleBackColor = false;
            this.btnidprint.Click += new System.EventHandler(this.btnidprint_Click);
            // 
            // btnidview
            // 
            this.btnidview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnidview.Image = global::SmartSchoolManagementSystem.Properties.Resources.view;
            this.btnidview.Location = new System.Drawing.Point(11, 19);
            this.btnidview.Name = "btnidview";
            this.btnidview.Size = new System.Drawing.Size(54, 35);
            this.btnidview.TabIndex = 0;
            this.btnidview.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BackgroundImage = global::SmartSchoolManagementSystem.Properties.Resources.stcd;
            this.panel2.Location = new System.Drawing.Point(2, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 40);
            this.panel2.TabIndex = 2;
            // 
            // cbbmedium
            // 
            this.cbbmedium.FormattingEnabled = true;
            this.cbbmedium.Location = new System.Drawing.Point(81, 86);
            this.cbbmedium.Name = "cbbmedium";
            this.cbbmedium.Size = new System.Drawing.Size(229, 21);
            this.cbbmedium.TabIndex = 2;
            // 
            // cbbgroup
            // 
            this.cbbgroup.FormattingEnabled = true;
            this.cbbgroup.Location = new System.Drawing.Point(81, 59);
            this.cbbgroup.Name = "cbbgroup";
            this.cbbgroup.Size = new System.Drawing.Size(229, 21);
            this.cbbgroup.TabIndex = 3;
            // 
            // StudentIdCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 251);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentIdCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Id Card Form";
            this.Load += new System.EventHandler(this.StudentIdCardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbsection;
        private System.Windows.Forms.ComboBox cbbclass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnidpreview;
        private System.Windows.Forms.Button btnidprint;
        private System.Windows.Forms.Button btnidview;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbbmedium;
        private System.Windows.Forms.ComboBox cbbgroup;
    }
}