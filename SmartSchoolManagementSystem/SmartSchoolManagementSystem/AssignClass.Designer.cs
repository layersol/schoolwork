namespace SmartSchoolManagementSystem
{
    partial class AssignClass
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txttid = new System.Windows.Forms.TextBox();
            this.txttname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbtclass = new System.Windows.Forms.ComboBox();
            this.cbbtsection = new System.Windows.Forms.ComboBox();
            this.btnassign = new System.Windows.Forms.Button();
            this.btnassigncancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgdassignview = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdassignview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Class To Teacher";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnassigncancel);
            this.panel2.Controls.Add(this.btnassign);
            this.panel2.Controls.Add(this.cbbtsection);
            this.panel2.Controls.Add(this.cbbtclass);
            this.panel2.Controls.Add(this.txttname);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txttid);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 118);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Teacher ID";
            // 
            // txttid
            // 
            this.txttid.Location = new System.Drawing.Point(83, 12);
            this.txttid.Name = "txttid";
            this.txttid.Size = new System.Drawing.Size(80, 20);
            this.txttid.TabIndex = 1;
            // 
            // txttname
            // 
            this.txttname.Location = new System.Drawing.Point(278, 12);
            this.txttname.Name = "txttname";
            this.txttname.Size = new System.Drawing.Size(188, 20);
            this.txttname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teacher Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Section";
            // 
            // cbbtclass
            // 
            this.cbbtclass.FormattingEnabled = true;
            this.cbbtclass.Location = new System.Drawing.Point(83, 43);
            this.cbbtclass.Name = "cbbtclass";
            this.cbbtclass.Size = new System.Drawing.Size(80, 21);
            this.cbbtclass.TabIndex = 4;
            // 
            // cbbtsection
            // 
            this.cbbtsection.FormattingEnabled = true;
            this.cbbtsection.Location = new System.Drawing.Point(278, 44);
            this.cbbtsection.Name = "cbbtsection";
            this.cbbtsection.Size = new System.Drawing.Size(188, 21);
            this.cbbtsection.TabIndex = 4;
            // 
            // btnassign
            // 
            this.btnassign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnassign.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassign.Location = new System.Drawing.Point(278, 82);
            this.btnassign.Name = "btnassign";
            this.btnassign.Size = new System.Drawing.Size(90, 31);
            this.btnassign.TabIndex = 5;
            this.btnassign.Text = "Assign";
            this.btnassign.UseVisualStyleBackColor = false;
            // 
            // btnassigncancel
            // 
            this.btnassigncancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnassigncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnassigncancel.Location = new System.Drawing.Point(370, 82);
            this.btnassigncancel.Name = "btnassigncancel";
            this.btnassigncancel.Size = new System.Drawing.Size(90, 31);
            this.btnassigncancel.TabIndex = 5;
            this.btnassigncancel.Text = "Cancel";
            this.btnassigncancel.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dgdassignview);
            this.panel3.Location = new System.Drawing.Point(2, 171);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(471, 321);
            this.panel3.TabIndex = 2;
            // 
            // dgdassignview
            // 
            this.dgdassignview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdassignview.Location = new System.Drawing.Point(3, 3);
            this.dgdassignview.Name = "dgdassignview";
            this.dgdassignview.Size = new System.Drawing.Size(462, 313);
            this.dgdassignview.TabIndex = 0;
            // 
            // AssignClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 492);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AssignClass";
            this.Text = "Assign Class";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgdassignview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txttname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbtsection;
        private System.Windows.Forms.ComboBox cbbtclass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnassigncancel;
        private System.Windows.Forms.Button btnassign;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgdassignview;
    }
}