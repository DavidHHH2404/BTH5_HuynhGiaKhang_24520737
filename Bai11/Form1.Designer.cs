namespace Bai11
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEllipse = new System.Windows.Forms.RadioButton();
            this.radRect = new System.Windows.Forms.RadioButton();
            this.radLine = new System.Windows.Forms.RadioButton();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radSolid = new System.Windows.Forms.RadioButton();
            this.radHatch = new System.Windows.Forms.RadioButton();
            this.radTexture = new System.Windows.Forms.RadioButton();
            this.radLinear = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(255, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(642, 547);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 547);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEllipse);
            this.groupBox1.Controls.Add(this.radRect);
            this.groupBox1.Controls.Add(this.radLine);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 140);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shapes";
            // 
            // radEllipse
            // 
            this.radEllipse.AutoSize = true;
            this.radEllipse.Location = new System.Drawing.Point(6, 103);
            this.radEllipse.Name = "radEllipse";
            this.radEllipse.Size = new System.Drawing.Size(72, 22);
            this.radEllipse.TabIndex = 2;
            this.radEllipse.TabStop = true;
            this.radEllipse.Text = "Ellipse";
            this.radEllipse.UseVisualStyleBackColor = true;
            // 
            // radRect
            // 
            this.radRect.AutoSize = true;
            this.radRect.Location = new System.Drawing.Point(6, 66);
            this.radRect.Name = "radRect";
            this.radRect.Size = new System.Drawing.Size(95, 22);
            this.radRect.TabIndex = 1;
            this.radRect.TabStop = true;
            this.radRect.Text = "Rectangle";
            this.radRect.UseVisualStyleBackColor = true;
            // 
            // radLine
            // 
            this.radLine.AutoSize = true;
            this.radLine.Checked = true;
            this.radLine.Location = new System.Drawing.Point(6, 30);
            this.radLine.Name = "radLine";
            this.radLine.Size = new System.Drawing.Size(56, 22);
            this.radLine.TabIndex = 0;
            this.radLine.TabStop = true;
            this.radLine.Text = "Line";
            this.radLine.UseVisualStyleBackColor = true;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(68, 36);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(77, 24);
            this.txtWidth.TabIndex = 1;
            this.txtWidth.Text = "5";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(58, 85);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(98, 33);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "Color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnColor);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 124);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radLinear);
            this.groupBox3.Controls.Add(this.radTexture);
            this.groupBox3.Controls.Add(this.radHatch);
            this.groupBox3.Controls.Add(this.radSolid);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 213);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Brushes";
            // 
            // radSolid
            // 
            this.radSolid.AutoSize = true;
            this.radSolid.Checked = true;
            this.radSolid.Location = new System.Drawing.Point(19, 34);
            this.radSolid.Name = "radSolid";
            this.radSolid.Size = new System.Drawing.Size(101, 22);
            this.radSolid.TabIndex = 0;
            this.radSolid.TabStop = true;
            this.radSolid.Text = "SolidBrush";
            this.radSolid.UseVisualStyleBackColor = true;
            // 
            // radHatch
            // 
            this.radHatch.AutoSize = true;
            this.radHatch.Location = new System.Drawing.Point(19, 71);
            this.radHatch.Name = "radHatch";
            this.radHatch.Size = new System.Drawing.Size(107, 22);
            this.radHatch.TabIndex = 1;
            this.radHatch.TabStop = true;
            this.radHatch.Text = "HatchBrush";
            this.radHatch.UseVisualStyleBackColor = true;
            // 
            // radTexture
            // 
            this.radTexture.AutoSize = true;
            this.radTexture.Location = new System.Drawing.Point(19, 112);
            this.radTexture.Name = "radTexture";
            this.radTexture.Size = new System.Drawing.Size(117, 22);
            this.radTexture.TabIndex = 2;
            this.radTexture.TabStop = true;
            this.radTexture.Text = "TextureBrush";
            this.radTexture.UseVisualStyleBackColor = true;
            // 
            // radLinear
            // 
            this.radLinear.AutoSize = true;
            this.radLinear.Location = new System.Drawing.Point(19, 151);
            this.radLinear.Name = "radLinear";
            this.radLinear.Size = new System.Drawing.Size(164, 22);
            this.radLinear.TabIndex = 3;
            this.radLinear.TabStop = true;
            this.radLinear.Text = "LinearGradientBrush";
            this.radLinear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLine;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.RadioButton radEllipse;
        private System.Windows.Forms.RadioButton radRect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radLinear;
        private System.Windows.Forms.RadioButton radTexture;
        private System.Windows.Forms.RadioButton radHatch;
        private System.Windows.Forms.RadioButton radSolid;
    }
}

