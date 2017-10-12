using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartSchoolManagementSystem.Control
{
    public partial class Circularprogressbar : UserControl
    {
        int progress;
        public Circularprogressbar()
        {
            progress= 1;
            InitializeComponent();
        }

        private void Circularprogressbar_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Width / 2, this.Height / 2);
            e.Graphics.RotateTransform(-90);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Pen obj_pen = new Pen(Color.Green);
            Rectangle obj_rect = new Rectangle(0 - this.Width / 2 + 20, 0 - this.Height / 2 + 20,this.Width-40,this.Height-40);
            e.Graphics.DrawPie(obj_pen,obj_rect,0,(int)(this.progress*3.6));
            e.Graphics.FillPie(new SolidBrush(Color.Green), obj_rect, 0, (int)(this.progress * 3.6));

             obj_pen = new Pen(Color.White);
             obj_rect = new Rectangle(0 - this.Width / 2 + 30, 0 - this.Height / 2 + 30, this.Width - 60, this.Height - 60);
            e.Graphics.DrawPie(obj_pen, obj_rect, 0, 360);
            e.Graphics.FillPie(new SolidBrush(Color.White), obj_rect, 0, 360);
            e.Graphics.RotateTransform(90);
            StringFormat ft = new StringFormat();
            ft.LineAlignment = StringAlignment.Center;
            ft.Alignment = StringAlignment.Center;
                e.Graphics.DrawString("100%", new Font("arial", 12), new SolidBrush(Color.Green), obj_rect,ft);
                
        }
        public void Updateprogress(int progress)
        {
            this.progress = progress;
        }
    }
}
