namespace SmartSchoolManagementSystem
{
    partial class AllStaff
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
            this.dgvattendace = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btngap = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendace)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvattendace);
            this.groupBox1.Location = new System.Drawing.Point(243, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 427);
            this.groupBox1.TabIndex = 24;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsearch);
            this.groupBox2.Controls.Add(this.btngap);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 421);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnsearch.ForeColor = System.Drawing.Color.Red;
            this.btnsearch.Location = new System.Drawing.Point(21, 41);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(135, 39);
            this.btnsearch.TabIndex = 12;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // btngap
            // 
            this.btngap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btngap.Location = new System.Drawing.Point(21, 86);
            this.btngap.Name = "btngap";
            this.btngap.Size = new System.Drawing.Size(135, 36);
            this.btngap.TabIndex = 13;
            this.btngap.Text = "Go All Present";
            this.btngap.UseVisualStyleBackColor = false;
            this.btngap.Click += new System.EventHandler(this.btngap_Click);
            // 
            // AllStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "AllStaff";
            this.Text = "AllStaff";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvattendace)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvattendace;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btngap;
    }
}