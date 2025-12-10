using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamily in installedFontCollection.Families)
            {
                if (!fontFamily.IsStyleAvailable(FontStyle.Regular)) continue;
                listFont.Items.Add(fontFamily.Name);
            }
        }

        private void listFont_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            e.DrawBackground();
            string fontName = listFont.Items[e.Index].ToString();
            Font fontToDraw;
            try
            {
                fontToDraw = new Font(fontName, 14, FontStyle.Regular);
            }
            catch
            {
                fontToDraw = new Font("Arial", 14, FontStyle.Regular);
            }
            Brush textBrush;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                textBrush = Brushes.White;
            }
            else
            {
                textBrush = Brushes.Black;
            }
            e.Graphics.DrawString(fontName, fontToDraw, textBrush, e.Bounds);
            e.DrawFocusRectangle();
        }
    }
}
