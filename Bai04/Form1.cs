using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily fontFamily in installedFontCollection.Families)
            {
                cbFont.Items.Add(fontFamily.Name);
            }
            cbFont.SelectedItem = "Arial";
            int[] sizes = { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (int size in sizes)
            {
                cbSize.Items.Add(size);
            }
            cbSize.SelectedItem = 14;
            CapNhap();
            btnCenter.Checked = true;
            btnColor.BackColor = Color.Black;
            txtHienThi.ForeColor = btnColor.BackColor;
        }
        private void CapNhap()
        {
            if (cbFont.SelectedItem == null) return;

            string fontName = cbFont.SelectedItem.ToString();
            float fontSize;
            bool isNumber = float.TryParse(cbSize.Text, out fontSize);

            if (!isNumber || fontSize <= 0)
            {
                fontSize = 14;
            }

            FontStyle fontStyle = FontStyle.Regular;

            if (ckbBold.Checked) fontStyle |= FontStyle.Bold;
            if (ckbItalic.Checked) fontStyle |= FontStyle.Italic;
            if (ckbUnder.Checked) fontStyle |= FontStyle.Underline;


            try
            {
                txtHienThi.Font = new Font(fontName, fontSize, fontStyle);
            }
            catch (Exception)
            {
                txtHienThi.Font = new Font("Arial", fontSize, fontStyle);
            }
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhap();
        }

        private void cbSize_TextChanged(object sender, EventArgs e)
        {
            CapNhap();
        }

        private void btnLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (btnLeft.Checked)
                txtHienThi.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void btnCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCenter.Checked)
                txtHienThi.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void btnRight_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRight.Checked)
                txtHienThi.TextAlign = ContentAlignment.MiddleRight;
        }

        private void ckbBold_CheckedChanged(object sender, EventArgs e)
        {
            CapNhap();
        }
        private void ckbItalic_CheckedChanged(object sender, EventArgs e)
        {
            CapNhap();
        }
        private void ckbUnder_CheckedChanged(object sender, EventArgs e)
        {
            CapNhap();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = colorDialog.Color;
                txtHienThi.ForeColor = btnColor.BackColor;
            }
        }
    }
}
