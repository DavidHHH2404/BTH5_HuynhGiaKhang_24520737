namespace Bai6
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
            this.listFont = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listFont
            // 
            this.listFont.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listFont.FormattingEnabled = true;
            this.listFont.ItemHeight = 40;
            this.listFont.Location = new System.Drawing.Point(12, 12);
            this.listFont.Name = "listFont";
            this.listFont.Size = new System.Drawing.Size(477, 484);
            this.listFont.TabIndex = 0;
            this.listFont.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listFont_DrawItem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 529);
            this.Controls.Add(this.listFont);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFont;
    }
}

