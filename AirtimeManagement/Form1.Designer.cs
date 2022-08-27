namespace AirtimeManagement
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imageToTextBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uploadImageBtn = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageToTextBtn
            // 
            this.imageToTextBtn.Location = new System.Drawing.Point(584, 503);
            this.imageToTextBtn.Name = "imageToTextBtn";
            this.imageToTextBtn.Size = new System.Drawing.Size(428, 70);
            this.imageToTextBtn.TabIndex = 0;
            this.imageToTextBtn.Text = "Image To Text";
            this.imageToTextBtn.UseVisualStyleBackColor = true;
            this.imageToTextBtn.Click += new System.EventHandler(this.imageToTextBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(46, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // uploadImageBtn
            // 
            this.uploadImageBtn.Location = new System.Drawing.Point(68, 503);
            this.uploadImageBtn.Name = "uploadImageBtn";
            this.uploadImageBtn.Size = new System.Drawing.Size(428, 70);
            this.uploadImageBtn.TabIndex = 2;
            this.uploadImageBtn.Text = "Upload Image";
            this.uploadImageBtn.UseVisualStyleBackColor = true;
            this.uploadImageBtn.Click += new System.EventHandler(this.uploadImageBtn_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(557, 48);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(491, 436);
            this.textBox.TabIndex = 3;
            this.textBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2163, 1016);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.uploadImageBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageToTextBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button imageToTextBtn;
        private PictureBox pictureBox1;
        private Button uploadImageBtn;
        private RichTextBox textBox;
    }
}