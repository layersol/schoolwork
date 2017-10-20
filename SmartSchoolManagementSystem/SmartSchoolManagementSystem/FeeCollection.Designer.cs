namespace SmartSchoolManagementSystem
{
    partial class FeeCollection
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
            this.txtstdid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBoxstdpic = new System.Windows.Forms.PictureBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnstdprint = new System.Windows.Forms.Button();
            this.btnstdpreview = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstdpic)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.BackgroundImage = global::SmartSchoolManagementSystem.Properties.Resources.feecst;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtstdid);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 59);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtstdid
            // 
            this.txtstdid.Location = new System.Drawing.Point(102, 22);
            this.txtstdid.Name = "txtstdid";
            this.txtstdid.Size = new System.Drawing.Size(170, 20);
            this.txtstdid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblshow);
            this.panel3.Location = new System.Drawing.Point(1, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 204);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBoxstdpic);
            this.panel5.Location = new System.Drawing.Point(276, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(132, 132);
            this.panel5.TabIndex = 3;
            // 
            // pictureBoxstdpic
            // 
            this.pictureBoxstdpic.Image = global::SmartSchoolManagementSystem.Properties.Resources.imageicon121;
            this.pictureBoxstdpic.Location = new System.Drawing.Point(4, 4);
            this.pictureBoxstdpic.Name = "pictureBoxstdpic";
            this.pictureBoxstdpic.Size = new System.Drawing.Size(121, 123);
            this.pictureBoxstdpic.TabIndex = 0;
            this.pictureBoxstdpic.TabStop = false;
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblshow.Location = new System.Drawing.Point(11, 3);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(115, 17);
            this.lblshow.TabIndex = 0;
            this.lblshow.Text = "Show Message";
            this.lblshow.Click += new System.EventHandler(this.lblshow_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.btnstdprint);
            this.panel4.Controls.Add(this.btnstdpreview);
            this.panel4.Location = new System.Drawing.Point(1, 319);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(413, 45);
            this.panel4.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(180, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 37);
            this.button3.TabIndex = 0;
            this.button3.Text = "Close";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnstdprint
            // 
            this.btnstdprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnstdprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstdprint.Location = new System.Drawing.Point(93, 3);
            this.btnstdprint.Name = "btnstdprint";
            this.btnstdprint.Size = new System.Drawing.Size(81, 37);
            this.btnstdprint.TabIndex = 0;
            this.btnstdprint.Text = "Print";
            this.btnstdprint.UseVisualStyleBackColor = false;
            // 
            // btnstdpreview
            // 
            this.btnstdpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnstdpreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstdpreview.Location = new System.Drawing.Point(6, 3);
            this.btnstdpreview.Name = "btnstdpreview";
            this.btnstdpreview.Size = new System.Drawing.Size(81, 37);
            this.btnstdpreview.TabIndex = 0;
            this.btnstdpreview.Text = "Preview";
            this.btnstdpreview.UseVisualStyleBackColor = false;
            // 
            // FeeCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 370);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FeeCollection";
            this.Text = "Fee Collection";
            this.Load += new System.EventHandler(this.FeeCollection_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxstdpic)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtstdid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnstdprint;
        private System.Windows.Forms.Button btnstdpreview;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBoxstdpic;
    }
}