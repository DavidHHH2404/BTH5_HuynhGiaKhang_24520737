using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Form1 : Form
    {
        private Timer clock;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            clock = new Timer();
            clock.Interval = 1000;
            clock.Tick += timer1_Tick;
            clock.Start();

            this.Paint += Form1_Paint;
            this.Resize += (s, e) => this.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = this.ClientSize.Width / 2;
            int centerY = this.ClientSize.Height / 2;
            int radius = Math.Min(centerX, centerY) - 20;

            for (int i = 0; i < 60; i++)
            {
                double angle = (i * 6 - 90) * Math.PI / 180;

                float x = centerX + (float)(radius * Math.Cos(angle));
                float y = centerY + (float)(radius * Math.Sin(angle));

                if (i % 5 == 0)
                {
                    g.FillEllipse(Brushes.White, x - 6, y - 6, 12, 12);
                }
                else
                {
                    g.FillEllipse(Brushes.White, x - 2, y - 2, 4, 4);
                }
            }
            DateTime now = DateTime.Now;
            float hourAngle = (now.Hour % 12 + now.Minute / 60.0f) * 30;
            DrawHand(g, centerX, centerY, hourAngle, radius * 0.7f, 17, Pens.White);

            float minuteAngle = (now.Minute + now.Second / 60.0f) * 6;
            DrawHand(g, centerX, centerY, minuteAngle, radius * 0.8f, 10, Pens.White);

            float secondAngle = now.Second * 6;
            g.TranslateTransform(centerX, centerY);
            g.RotateTransform(secondAngle - 90);
            g.DrawLine(Pens.White, 0, 0, radius * 0.85f, 0); 
            g.ResetTransform();
        }


        private void DrawHand(Graphics g, int cx, int cy, float angle, float headLength, float width, Pen pen)
        {
            GraphicsState state = g.Save();

            g.TranslateTransform(cx, cy);

            g.RotateTransform(angle - 90);

            float tailLength = headLength * 0.25f;

            PointF[] points = new PointF[]
            {
               new PointF(-tailLength, 0),   
               new PointF(0, width),         
               new PointF(headLength, 0),    
               new PointF(0, -width)         
            };

            g.DrawPolygon(pen, points);
            g.Restore(state);
        }
    }
}
