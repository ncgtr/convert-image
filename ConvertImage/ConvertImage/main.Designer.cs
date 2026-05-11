namespace ConvertImage
{
    partial class main
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
            this.label1 = new System.Windows.Forms.Label();
            this.formatList = new System.Windows.Forms.ComboBox();
            this.sizeList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Format";
            // 
            // formatList
            // 
            this.formatList.FormattingEnabled = true;
            this.formatList.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "GIF",
            "BMP",
            "ICO",
            "EXIF",
            "TIFF",
            "EMF",
            "WMF"});
            this.formatList.Location = new System.Drawing.Point(87, 12);
            this.formatList.Name = "formatList";
            this.formatList.Size = new System.Drawing.Size(285, 23);
            this.formatList.TabIndex = 1;
            // 
            // sizeList
            // 
            this.sizeList.FormattingEnabled = true;
            this.sizeList.Items.AddRange(new object[] {
            "25%",
            "33%",
            "50%",
            "62%",
            "75%",
            "87%",
            "100%",
            "125%",
            "133%",
            "150%",
            "162%",
            "175%",
            "187%",
            "200%"});
            this.sizeList.Location = new System.Drawing.Point(87, 41);
            this.sizeList.Name = "sizeList";
            this.sizeList.Size = new System.Drawing.Size(285, 23);
            this.sizeList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Image Size";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(222, 78);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(150, 23);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert 2 Images";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(146, 78);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(70, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(384, 113);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.sizeList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formatList);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.main_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox formatList;
        private System.Windows.Forms.ComboBox sizeList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

