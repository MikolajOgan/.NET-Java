namespace lab33
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
            richTextBox2 = new RichTextBox();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            button4 = new Button();
            richTextBox3 = new RichTextBox();
            textBox2 = new TextBox();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(14, 17);
            button1.Name = "button1";
            button1.Size = new Size(158, 71);
            button1.TabIndex = 0;
            button1.Text = "Test";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(187, 14);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(568, 424);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(761, 17);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(658, 424);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // button2
            // 
            button2.Location = new Point(14, 94);
            button2.Name = "button2";
            button2.Size = new Size(158, 68);
            button2.TabIndex = 3;
            button2.Text = "Test Threads";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(14, 168);
            button3.Name = "button3";
            button3.Size = new Size(158, 74);
            button3.TabIndex = 4;
            button3.Text = "Test parallel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 411);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 5;
            textBox1.Text = "4";
            // 
            // button4
            // 
            button4.Location = new Point(14, 248);
            button4.Name = "button4";
            button4.Size = new Size(156, 65);
            button4.TabIndex = 6;
            button4.Text = "Measure time";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(187, 444);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(568, 392);
            richTextBox3.TabIndex = 7;
            richTextBox3.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 378);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 8;
            textBox2.Text = "20";
            // 
            // button5
            // 
            button5.Location = new Point(761, 447);
            button5.Name = "button5";
            button5.Size = new Size(658, 389);
            button5.TabIndex = 9;
            button5.Text = "Images";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 848);
            Controls.Add(button5);
            Controls.Add(textBox2);
            Controls.Add(richTextBox3);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Button button4;
        private RichTextBox richTextBox3;
        private TextBox textBox2;
        private Button button5;
    }
}
