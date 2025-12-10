using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
    
namespace Bai11
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;

        private Color currentColor = Color.Black;
        private Bitmap mainBitmap;
        private Bitmap textureImage;

        public Form1()
        {
            InitializeComponent();
            mainBitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(mainBitmap))
            {
                g.Clear(Color.White);
            }
            pictureBox1.Image = mainBitmap;
            CreateSampleTexture();
        }

        private void CreateSampleTexture()
        {
            textureImage = new Bitmap(20, 20);
            using (Graphics g = Graphics.FromImage(textureImage))
            {
                g.Clear(Color.LightGray);
                g.FillRectangle(Brushes.Gray, 0, 0, 10, 10);
                g.FillRectangle(Brushes.Gray, 10, 10, 10, 10);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;

                using (Graphics g = Graphics.FromImage(mainBitmap))
                {
                    DrawShape(g);
                }

                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                endPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (isDrawing)
            {
                DrawShape(e.Graphics);
            }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }


        private void DrawShape(Graphics g)
        {
            if (g == null) return;

            g.SmoothingMode = SmoothingMode.AntiAlias;

            int width = 1;
            int.TryParse(txtWidth.Text, out width);

            if (radLine.Checked)
            {
                using (Pen p = new Pen(currentColor, width))
                {
                    g.DrawLine(p, startPoint, endPoint);
                }
            }
            else
            {
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int w = Math.Abs(startPoint.X - endPoint.X);
                int h = Math.Abs(startPoint.Y - endPoint.Y);
                Rectangle rect = new Rectangle(x, y, w, h);

                if (w == 0 || h == 0) return;

                Brush myBrush = null;

                if (radSolid.Checked)
                {
                    myBrush = new SolidBrush(Color.Green);
                }
                else if (radHatch.Checked)
                {
                    myBrush = new HatchBrush(HatchStyle.Horizontal, Color.Blue, Color.Green);
                }
                else if (radTexture.Checked)
                {
                    // TextureBrush
                    if (textureImage != null)
                        myBrush = new TextureBrush(textureImage);
                    else
                        myBrush = new SolidBrush(Color.Gray);
                }
                else if (radLinear.Checked)
                {
                    myBrush = new LinearGradientBrush(rect, Color.Red, Color.Green, LinearGradientMode.Vertical);
                }

                if (myBrush != null)
                {
                    if (radRect.Checked)
                        g.FillRectangle(myBrush, rect);
                    else if (radEllipse.Checked)
                        g.FillEllipse(myBrush, rect);

                    myBrush.Dispose();
                }
            }
        }
    }
}
