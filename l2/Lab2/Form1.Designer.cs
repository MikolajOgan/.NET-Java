namespace Lab2
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 71);
            button1.Name = "button1";
            button1.Size = new Size(318, 97);
            button1.TabIndex = 0;
            button1.Text = "Get from API";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(348, 38);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(322, 477);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 38);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "API index";
            textBox1.Size = new Size(318, 27);
            textBox1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(676, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(424, 469);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 519);
            Controls.Add(pictureBox2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
