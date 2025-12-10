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

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty |
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic,
                null, pnlDraw, new object[] { true });
        }
        private void ControlChanged(object sender, EventArgs e)
        {
            pnlDraw.Invalidate();
        }
        private void pnlDraw_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            try
            {
                DashStyle ds = (DashStyle)Enum.Parse(typeof(DashStyle), cbDashStyle.Text);
                int w = int.Parse(cbWidth.Text);
                LineJoin lj = (LineJoin)Enum.Parse(typeof(LineJoin), cbLineJoin.Text);
                DashCap dc = (DashCap)Enum.Parse(typeof(DashCap), cbDashCap.Text);
                LineCap sc = (LineCap)Enum.Parse(typeof(LineCap), cbStartCap.Text);
                LineCap ec = (LineCap)Enum.Parse(typeof(LineCap), cbEndCap.Text);

                using (Pen p = new Pen(Color.Red, w))
                {
                    p.DashStyle = ds;
                    if (ds == DashStyle.Custom)
                    {
                        p.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };
                    }
                    p.LineJoin = lj;
                    p.DashCap = dc;
                    p.StartCap = sc;
                    p.EndCap = ec;

                    GraphicsPath path = new GraphicsPath();
                    Point p1 = new Point(30, 30);
                    Point p2 = new Point(pnlDraw.Width / 2, pnlDraw.Height - 50);
                    Point p3 = new Point(pnlDraw.Width - 30, 50);

                    path.AddLine(p1, p2);
                    path.AddLine(p2, p3);

                    g.DrawPath(p, path);
                }
            }
            catch
            {
            }
        }
    }
}
