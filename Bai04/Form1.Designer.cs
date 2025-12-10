namespace Bai04
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ckbBold = new System.Windows.Forms.CheckBox();
            this.ckbItalic = new System.Windows.Forms.CheckBox();
            this.ckbUnder = new System.Windows.Forms.CheckBox();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRight = new System.Windows.Forms.RadioButton();
            this.btnCenter = new System.Windows.Forms.RadioButton();
            this.btnLeft = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtHienThi = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckbBold
            // 
            this.ckbBold.AutoSize = true;
            this.ckbBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBold.Location = new System.Drawing.Point(23, 103);
            this.ckbBold.Name = "ckbBold";
            this.ckbBold.Size = new System.Drawing.Size(44, 24);
            this.ckbBold.TabIndex = 0;
            this.ckbBold.Text = "B";
            this.ckbBold.UseVisualStyleBackColor = true;
            this.ckbBold.CheckedChanged += new System.EventHandler(this.ckbBold_CheckedChanged);
            // 
            // ckbItalic
            // 
            this.ckbItalic.AutoSize = true;
            this.ckbItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbItalic.Location = new System.Drawing.Point(73, 103);
            this.ckbItalic.Name = "ckbItalic";
            this.ckbItalic.Size = new System.Drawing.Size(35, 24);
            this.ckbItalic.TabIndex = 1;
            this.ckbItalic.Text = "I";
            this.ckbItalic.UseVisualStyleBackColor = true;
            this.ckbItalic.CheckedChanged += new System.EventHandler(this.ckbItalic_CheckedChanged);
            // 
            // ckbUnder
            // 
            this.ckbUnder.AutoSize = true;
            this.ckbUnder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUnder.Location = new System.Drawing.Point(114, 103);
            this.ckbUnder.Name = "ckbUnder";
            this.ckbUnder.Size = new System.Drawing.Size(43, 24);
            this.ckbUnder.TabIndex = 2;
            this.ckbUnder.Text = "U";
            this.ckbUnder.UseVisualStyleBackColor = true;
            this.ckbUnder.CheckedChanged += new System.EventHandler(this.ckbUnder_CheckedChanged);
            // 
            // cbFont
            // 
            this.cbFont.BackColor = System.Drawing.SystemColors.Window;
            this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(67, 53);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(179, 24);
            this.cbFont.TabIndex = 3;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(309, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Size";
            // 
            // cbSize
            // 
            this.cbSize.FormattingEnabled = true;
            this.cbSize.Location = new System.Drawing.Point(357, 57);
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(83, 24);
            this.cbSize.TabIndex = 6;
            this.cbSize.TextChanged += new System.EventHandler(this.cbSize_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(302, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(357, 101);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(38, 34);
            this.btnColor.TabIndex = 8;
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRight);
            this.groupBox1.Controls.Add(this.btnCenter);
            this.groupBox1.Controls.Add(this.btnLeft);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 141);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Align Text";
            // 
            // btnRight
            // 
            this.btnRight.AutoSize = true;
            this.btnRight.Location = new System.Drawing.Point(6, 109);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(69, 24);
            this.btnRight.TabIndex = 2;
            this.btnRight.TabStop = true;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.CheckedChanged += new System.EventHandler(this.btnRight_CheckedChanged);
            // 
            // btnCenter
            // 
            this.btnCenter.AutoSize = true;
            this.btnCenter.Location = new System.Drawing.Point(6, 68);
            this.btnCenter.Name = "btnCenter";
            this.btnCenter.Size = new System.Drawing.Size(80, 24);
            this.btnCenter.TabIndex = 1;
            this.btnCenter.TabStop = true;
            this.btnCenter.Text = "Center";
            this.btnCenter.UseVisualStyleBackColor = true;
            this.btnCenter.CheckedChanged += new System.EventHandler(this.btnCenter_CheckedChanged);
            // 
            // btnLeft
            // 
            this.btnLeft.AutoSize = true;
            this.btnLeft.Location = new System.Drawing.Point(6, 26);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(59, 24);
            this.btnLeft.TabIndex = 0;
            this.btnLeft.TabStop = true;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.CheckedChanged += new System.EventHandler(this.btnLeft_CheckedChanged);
            // 
            // txtHienThi
            // 
            this.txtHienThi.BackColor = System.Drawing.Color.White;
            this.txtHienThi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtHienThi.Location = new System.Drawing.Point(253, 198);
            this.txtHienThi.Name = "txtHienThi";
            this.txtHienThi.Size = new System.Drawing.Size(345, 92);
            this.txtHienThi.TabIndex = 10;
            this.txtHienThi.Text = "Hello";
            this.txtHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 362);
            this.Controls.Add(this.txtHienThi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFont);
            this.Controls.Add(this.ckbUnder);
            this.Controls.Add(this.ckbItalic);
            this.Controls.Add(this.ckbBold);
            this.Name = "Form1";
            this.Text = resources.GetString("$this.Text");
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckbBold;
        private System.Windows.Forms.CheckBox ckbItalic;
        private System.Windows.Forms.CheckBox ckbUnder;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnLeft;
        private System.Windows.Forms.RadioButton btnRight;
        private System.Windows.Forms.RadioButton btnCenter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label txtHienThi;
    }
}

