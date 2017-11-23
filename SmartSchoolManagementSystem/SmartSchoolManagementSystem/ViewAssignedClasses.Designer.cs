namespace SmartSchoolManagementSystem
{
    partial class ViewAssignedClasses
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtbyclass = new System.Windows.Forms.RadioButton();
            this.rbtall = new System.Windows.Forms.RadioButton();
            this.btngo = new System.Windows.Forms.Button();
            this.CBBSECTION = new System.Windows.Forms.ComboBox();
            this.CBBCLASS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgdviewassign = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdviewassign)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::SmartSchoolManagementSystem.Properties.Resources.vac;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbtbyclass);
            this.panel2.Controls.Add(this.rbtall);
            this.panel2.Controls.Add(this.btngo);
            this.panel2.Controls.Add(this.CBBSECTION);
            this.panel2.Controls.Add(this.CBBCLASS);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 58);
            this.panel2.TabIndex = 1;
            // 
            // rbtbyclass
            // 
            this.rbtbyclass.AutoSize = true;
            this.rbtbyclass.Location = new System.Drawing.Point(89, -1);
            this.rbtbyclass.Name = "rbtbyclass";
            this.rbtbyclass.Size = new System.Drawing.Size(76, 17);
            this.rbtbyclass.TabIndex = 6;
            this.rbtbyclass.TabStop = true;
            this.rbtbyclass.Text = "By Classes";
            this.rbtbyclass.UseVisualStyleBackColor = true;
            this.rbtbyclass.CheckedChanged += new System.EventHandler(this.rbtbyclass_CheckedChanged);
            // 
            // rbtall
            // 
            this.rbtall.AutoSize = true;
            this.rbtall.Checked = true;
            this.rbtall.Location = new System.Drawing.Point(49, -1);
            this.rbtall.Name = "rbtall";
            this.rbtall.Size = new System.Drawing.Size(36, 17);
            this.rbtall.TabIndex = 5;
            this.rbtall.TabStop = true;
            this.rbtall.Text = "All";
            this.rbtall.UseVisualStyleBackColor = true;
            this.rbtall.CheckedChanged += new System.EventHandler(this.rbtall_CheckedChanged);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(359, 25);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(75, 23);
            this.btngo.TabIndex = 4;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // CBBSECTION
            // 
            this.CBBSECTION.FormattingEnabled = true;
            this.CBBSECTION.Location = new System.Drawing.Point(232, 25);
            this.CBBSECTION.Name = "CBBSECTION";
            this.CBBSECTION.Size = new System.Drawing.Size(121, 21);
            this.CBBSECTION.TabIndex = 3;
            this.CBBSECTION.Visible = false;
            // 
            // CBBCLASS
            // 
            this.CBBCLASS.FormattingEnabled = true;
            this.CBBCLASS.Location = new System.Drawing.Point(53, 25);
            this.CBBCLASS.Name = "CBBCLASS";
            this.CBBCLASS.Size = new System.Drawing.Size(300, 21);
            this.CBBCLASS.TabIndex = 2;
            this.CBBCLASS.SelectedIndexChanged += new System.EventHandler(this.CBBCLASS_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Section";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.dgdviewassign);
            this.panel3.Location = new System.Drawing.Point(1, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(643, 261);
            this.panel3.TabIndex = 2;
            // 
            // dgdviewassign
            // 
            this.dgdviewassign.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgdviewassign.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdviewassign.Location = new System.Drawing.Point(3, 4);
            this.dgdviewassign.Name = "dgdviewassign";
            this.dgdviewassign.Size = new System.Drawing.Size(631, 251);
            this.dgdviewassign.TabIndex = 0;
            // 
            // ViewAssignedClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 381);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewAssignedClasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Assigned Classes";
            this.Load += new System.EventHandler(this.ViewAssignedClasses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdviewassign)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgdviewassign;
        private System.Windows.Forms.ComboBox CBBSECTION;
        private System.Windows.Forms.ComboBox CBBCLASS;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.RadioButton rbtbyclass;
        private System.Windows.Forms.RadioButton rbtall;
    }
}