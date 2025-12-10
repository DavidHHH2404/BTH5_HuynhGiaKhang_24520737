namespace Bai10
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDashStyle = new System.Windows.Forms.ComboBox();
            this.cbWidth = new System.Windows.Forms.ComboBox();
            this.cbLineJoin = new System.Windows.Forms.ComboBox();
            this.cbEndCap = new System.Windows.Forms.ComboBox();
            this.cbStartCap = new System.Windows.Forms.ComboBox();
            this.cbDashCap = new System.Windows.Forms.ComboBox();
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbEndCap);
            this.groupBox1.Controls.Add(this.cbStartCap);
            this.groupBox1.Controls.Add(this.cbDashCap);
            this.groupBox1.Controls.Add(this.cbLineJoin);
            this.groupBox1.Controls.Add(this.cbWidth);
            this.groupBox1.Controls.Add(this.cbDashStyle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 449);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dash Style :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Line Join :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dash Cap :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Start Cap :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "End Cap :";
            // 
            // cbDashStyle
            // 
            this.cbDashStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDashStyle.FormattingEnabled = true;
            this.cbDashStyle.Items.AddRange(new object[] {
            "Solid",
            "Dash",
            "Dot",
            "DashDot",
            "DashDotDot",
            "Custom"});
            this.cbDashStyle.Location = new System.Drawing.Point(161, 42);
            this.cbDashStyle.Name = "cbDashStyle";
            this.cbDashStyle.Size = new System.Drawing.Size(180, 24);
            this.cbDashStyle.TabIndex = 7;
            this.cbDashStyle.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // cbWidth
            // 
            this.cbWidth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWidth.FormattingEnabled = true;
            this.cbWidth.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "15",
            "20"});
            this.cbWidth.Location = new System.Drawing.Point(161, 100);
            this.cbWidth.Name = "cbWidth";
            this.cbWidth.Size = new System.Drawing.Size(180, 24);
            this.cbWidth.TabIndex = 8;
            this.cbWidth.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // cbLineJoin
            // 
            this.cbLineJoin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLineJoin.FormattingEnabled = true;
            this.cbLineJoin.Items.AddRange(new object[] {
            "Miter",
            "Bevel",
            "Round",
            "MiterClipped"});
            this.cbLineJoin.Location = new System.Drawing.Point(161, 172);
            this.cbLineJoin.Name = "cbLineJoin";
            this.cbLineJoin.Size = new System.Drawing.Size(180, 24);
            this.cbLineJoin.TabIndex = 9;
            this.cbLineJoin.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // cbEndCap
            // 
            this.cbEndCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEndCap.FormattingEnabled = true;
            this.cbEndCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor"});
            this.cbEndCap.Location = new System.Drawing.Point(161, 376);
            this.cbEndCap.Name = "cbEndCap";
            this.cbEndCap.Size = new System.Drawing.Size(180, 24);
            this.cbEndCap.TabIndex = 12;
            this.cbEndCap.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // cbStartCap
            // 
            this.cbStartCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStartCap.FormattingEnabled = true;
            this.cbStartCap.Items.AddRange(new object[] {
            "Flat",
            "Square",
            "Round",
            "Triangle",
            "NoAnchor",
            "SquareAnchor",
            "RoundAnchor",
            "DiamondAnchor",
            "ArrowAnchor"});
            this.cbStartCap.Location = new System.Drawing.Point(161, 314);
            this.cbStartCap.Name = "cbStartCap";
            this.cbStartCap.Size = new System.Drawing.Size(180, 24);
            this.cbStartCap.TabIndex = 11;
            this.cbStartCap.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // cbDashCap
            // 
            this.cbDashCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDashCap.FormattingEnabled = true;
            this.cbDashCap.Items.AddRange(new object[] {
            "Flat",
            "Round",
            "Triangle"});
            this.cbDashCap.Location = new System.Drawing.Point(161, 243);
            this.cbDashCap.Name = "cbDashCap";
            this.cbDashCap.Size = new System.Drawing.Size(180, 24);
            this.cbDashCap.TabIndex = 10;
            this.cbDashCap.SelectedIndexChanged += new System.EventHandler(this.ControlChanged);
            // 
            // pnlDraw
            // 
            this.pnlDraw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDraw.BackColor = System.Drawing.Color.White;
            this.pnlDraw.Location = new System.Drawing.Point(376, 0);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(422, 449);
            this.pnlDraw.TabIndex = 1;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDraw);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEndCap;
        private System.Windows.Forms.ComboBox cbStartCap;
        private System.Windows.Forms.ComboBox cbDashCap;
        private System.Windows.Forms.ComboBox cbLineJoin;
        private System.Windows.Forms.ComboBox cbWidth;
        private System.Windows.Forms.ComboBox cbDashStyle;
        private System.Windows.Forms.Panel pnlDraw;
    }
}

