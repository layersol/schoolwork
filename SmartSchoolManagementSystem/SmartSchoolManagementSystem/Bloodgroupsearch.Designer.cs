namespace SmartSchoolManagementSystem
{
    partial class Bloodgroupsearch
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
            this.btnsearch = new System.Windows.Forms.Button();
            this.dgdview = new System.Windows.Forms.DataGridView();
            this.cbbbloodsearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SmartSchoolManagementSystem.Properties.Resources.blood;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnsearch);
            this.panel2.Controls.Add(this.dgdview);
            this.panel2.Controls.Add(this.cbbbloodsearch);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(671, 391);
            this.panel2.TabIndex = 1;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(364, 11);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(75, 23);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // dgdview
            // 
            this.dgdview.BackgroundColor = System.Drawing.Color.White;
            this.dgdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdview.Location = new System.Drawing.Point(13, 54);
            this.dgdview.Name = "dgdview";
            this.dgdview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdview.Size = new System.Drawing.Size(644, 330);
            this.dgdview.TabIndex = 2;
            // 
            // cbbbloodsearch
            // 
            this.cbbbloodsearch.FormattingEnabled = true;
            this.cbbbloodsearch.Items.AddRange(new object[] {
            "A+",
            "B+",
            "AB+",
            "O+",
            "A-",
            "B-",
            "AB-",
            "O-"});
            this.cbbbloodsearch.Location = new System.Drawing.Point(154, 11);
            this.cbbbloodsearch.Name = "cbbbloodsearch";
            this.cbbbloodsearch.Size = new System.Drawing.Size(203, 21);
            this.cbbbloodsearch.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Blood Group";
            // 
            // Bloodgroupsearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 449);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bloodgroupsearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Blood Group Search";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgdview;
        private System.Windows.Forms.ComboBox cbbbloodsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsearch;
    }
}