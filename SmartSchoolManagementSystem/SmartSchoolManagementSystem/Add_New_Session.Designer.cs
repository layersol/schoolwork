namespace SmartSchoolManagementSystem
{
    partial class Add_New_Session
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
            this.gbsession = new System.Windows.Forms.GroupBox();
            this.txtacadmicsession = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnview = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.gbsession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsession
            // 
            this.gbsession.Controls.Add(this.txtacadmicsession);
            this.gbsession.Controls.Add(this.label1);
            this.gbsession.Location = new System.Drawing.Point(8, 6);
            this.gbsession.Name = "gbsession";
            this.gbsession.Size = new System.Drawing.Size(255, 56);
            this.gbsession.TabIndex = 0;
            this.gbsession.TabStop = false;
            // 
            // txtacadmicsession
            // 
            this.txtacadmicsession.Location = new System.Drawing.Point(84, 19);
            this.txtacadmicsession.Name = "txtacadmicsession";
            this.txtacadmicsession.Size = new System.Drawing.Size(155, 20);
            this.txtacadmicsession.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Session";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnview);
            this.groupBox1.Controls.Add(this.btnsave);
            this.groupBox1.Location = new System.Drawing.Point(8, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 38);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(169, 10);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnview
            // 
            this.btnview.Location = new System.Drawing.Point(90, 10);
            this.btnview.Name = "btnview";
            this.btnview.Size = new System.Drawing.Size(75, 23);
            this.btnview.TabIndex = 1;
            this.btnview.Text = "View";
            this.btnview.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(11, 10);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 0;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // Add_New_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 110);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbsession);
            this.Name = "Add_New_Session";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Session";
            this.gbsession.ResumeLayout(false);
            this.gbsession.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsession;
        private System.Windows.Forms.TextBox txtacadmicsession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnview;
        private System.Windows.Forms.Button btnsave;
    }
}