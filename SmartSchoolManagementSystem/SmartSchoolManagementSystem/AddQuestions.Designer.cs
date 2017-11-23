namespace SmartSchoolManagementSystem
{
    partial class AddQuestions
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
            this.cbbclass = new System.Windows.Forms.ComboBox();
            this.cbbgroup = new System.Windows.Forms.ComboBox();
            this.cbbmedium = new System.Windows.Forms.ComboBox();
            this.cbbsubject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnq = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbsubject);
            this.groupBox1.Controls.Add(this.cbbmedium);
            this.groupBox1.Controls.Add(this.cbbgroup);
            this.groupBox1.Controls.Add(this.cbbclass);
            this.groupBox1.Location = new System.Drawing.Point(7, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 121);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbbclass
            // 
            this.cbbclass.FormattingEnabled = true;
            this.cbbclass.Location = new System.Drawing.Point(55, 12);
            this.cbbclass.Name = "cbbclass";
            this.cbbclass.Size = new System.Drawing.Size(121, 21);
            this.cbbclass.TabIndex = 0;
            // 
            // cbbgroup
            // 
            this.cbbgroup.FormattingEnabled = true;
            this.cbbgroup.Location = new System.Drawing.Point(55, 39);
            this.cbbgroup.Name = "cbbgroup";
            this.cbbgroup.Size = new System.Drawing.Size(121, 21);
            this.cbbgroup.TabIndex = 1;
            // 
            // cbbmedium
            // 
            this.cbbmedium.FormattingEnabled = true;
            this.cbbmedium.Items.AddRange(new object[] {
            "Science"});
            this.cbbmedium.Location = new System.Drawing.Point(55, 66);
            this.cbbmedium.Name = "cbbmedium";
            this.cbbmedium.Size = new System.Drawing.Size(121, 21);
            this.cbbmedium.TabIndex = 2;
            // 
            // cbbsubject
            // 
            this.cbbsubject.FormattingEnabled = true;
            this.cbbsubject.Location = new System.Drawing.Point(55, 93);
            this.cbbsubject.Name = "cbbsubject";
            this.cbbsubject.Size = new System.Drawing.Size(121, 21);
            this.cbbsubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "General";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medium";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Subject";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(200, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 344);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Question";
            // 
            // btnq
            // 
            this.btnq.Location = new System.Drawing.Point(102, 130);
            this.btnq.Name = "btnq";
            this.btnq.Size = new System.Drawing.Size(92, 23);
            this.btnq.TabIndex = 2;
            this.btnq.Text = "Save Question";
            this.btnq.UseVisualStyleBackColor = true;
            this.btnq.Click += new System.EventHandler(this.btnq_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(112, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(478, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(317, 20);
            this.textBox2.TabIndex = 1;
            // 
            // AddQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 359);
            this.Controls.Add(this.btnq);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddQuestions";
            this.Text = "AddQuestions";
            this.Load += new System.EventHandler(this.AddQuestions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbbgroup;
        private System.Windows.Forms.ComboBox cbbclass;
        private System.Windows.Forms.ComboBox cbbmedium;
        private System.Windows.Forms.ComboBox cbbsubject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnq;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}