using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 6;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(Color.Green, 3);
            Brush brush = new SolidBrush(Color.Red);

            Rectangle rect = new Rectangle(100, 100, 200, 150);
            Rectangle squarerect = new Rectangle(100, 100, 150, 150);

            string selectedShape = comboBox1.SelectedItem.ToString();

            switch(selectedShape)
            {
                case "Ellipse":
                    g.DrawEllipse(pen, rect);
                    break;
                case "Circle":
                    g.DrawEllipse(pen, squarerect);
                    break;  
                case "Square":
                    g.DrawRectangle(pen, squarerect);
                    break;
                case "Pie":
                    g.DrawPie(pen, squarerect, 0, 90);
                    break;
                case "Filled Ellipse":
                    g.FillEllipse(brush, rect);
                    break;
                case "Filled Pie":
                    g.FillPie(brush, squarerect, 0, 90);
                    break;
                case "Filled Square":
                    g.FillRectangle(brush, squarerect);
                    break;
                case "Filled Circle":
                    g.FillEllipse(brush, squarerect);
                    break;
            }
        }
    }
}
