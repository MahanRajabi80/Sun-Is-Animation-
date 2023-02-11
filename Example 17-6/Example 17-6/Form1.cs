using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_17_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------------------
        const int RADIUS = 50;
        int X = 180, Y = 100;
        //--------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.Black);
            gr.FillEllipse(Brushes.Yellow, X, Y, RADIUS * 2, RADIUS*2);
            float x1, y1, x2, y2;
            float r1 = RADIUS, r2 = r1;
            float teta;
            Random r = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i <= 360; i += r.Next(20) + 1)
            {
                teta = (float)(Math.PI * i / 180);
                x1 = (float)(r1 * Math.Cos(teta));
                y1 = (float)(r1 * Math.Sin(teta));
                int m = r.Next(50);
                r2 = r1 + m;
                x2 = (float)(r2 * Math.Cos(teta));
                y2 = (float)(r2 * Math.Sin(teta));
                gr.DrawLine(new Pen(Color.White), X + RADIUS + x1, Y + RADIUS + y1, X + RADIUS + x2, Y + RADIUS + y2);
            }
        }
    }
}
