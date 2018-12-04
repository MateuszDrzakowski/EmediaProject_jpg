namespace EmediaProject
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
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.magnitudeImage = new System.Windows.Forms.PictureBox();
            this.phaseImage = new System.Windows.Forms.PictureBox();
            this.inverseImage = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FFTbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.imageNameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inverseImage)).BeginInit();
            this.SuspendLayout();
            // 
            // originalImage
            // 
            this.originalImage.Location = new System.Drawing.Point(341, 41);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(256, 256);
            this.originalImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.originalImage.TabIndex = 0;
            this.originalImage.TabStop = false;
            // 
            // magnitudeImage
            // 
            this.magnitudeImage.Location = new System.Drawing.Point(625, 41);
            this.magnitudeImage.Name = "magnitudeImage";
            this.magnitudeImage.Size = new System.Drawing.Size(256, 256);
            this.magnitudeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.magnitudeImage.TabIndex = 1;
            this.magnitudeImage.TabStop = false;
            // 
            // phaseImage
            // 
            this.phaseImage.Location = new System.Drawing.Point(341, 348);
            this.phaseImage.Name = "phaseImage";
            this.phaseImage.Size = new System.Drawing.Size(256, 256);
            this.phaseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.phaseImage.TabIndex = 2;
            this.phaseImage.TabStop = false;
            // 
            // inverseImage
            // 
            this.inverseImage.Location = new System.Drawing.Point(625, 348);
            this.inverseImage.Name = "inverseImage";
            this.inverseImage.Size = new System.Drawing.Size(256, 256);
            this.inverseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.inverseImage.TabIndex = 3;
            this.inverseImage.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(22, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(230, 82);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // FFTbutton
            // 
            this.FFTbutton.Location = new System.Drawing.Point(26, 174);
            this.FFTbutton.Name = "FFTbutton";
            this.FFTbutton.Size = new System.Drawing.Size(75, 23);
            this.FFTbutton.TabIndex = 5;
            this.FFTbutton.Text = "FFT";
            this.FFTbutton.UseVisualStyleBackColor = true;
            this.FFTbutton.Click += new System.EventHandler(this.FFTbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(701, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fourier Magnitude Plot";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fourier Phase Plot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Inverse Image";
            // 
            // imageNameBox
            // 
            this.imageNameBox.Location = new System.Drawing.Point(125, 155);
            this.imageNameBox.Name = "imageNameBox";
            this.imageNameBox.Size = new System.Drawing.Size(100, 20);
            this.imageNameBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Podaj nazwę pliku:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 698);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.imageNameBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FFTbutton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.inverseImage);
            this.Controls.Add(this.phaseImage);
            this.Controls.Add(this.magnitudeImage);
            this.Controls.Add(this.originalImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.magnitudeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phaseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inverseImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }




        #endregion

        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.PictureBox magnitudeImage;
        private System.Windows.Forms.PictureBox phaseImage;
        private System.Windows.Forms.PictureBox inverseImage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button FFTbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox imageNameBox;
        private System.Windows.Forms.Label label5;
    }
}

