namespace SmartSchoolManagementSystem
{
    partial class ChangeClass
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(255, 26);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 0;
            this.btnsearch.Text = "button1";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(120, 26);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(129, 20);
            this.txtid.TabIndex = 1;
            // 
            // ChangeClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 346);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.btnsearch);
            this.Name = "ChangeClass";
            this.Text = "Change Class";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtid;
    }
}