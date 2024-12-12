namespace Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            numericUpDown1 = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            numericUpDown2 = new NumericUpDown();
            label5 = new Label();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            label6 = new Label();
            button2 = new Button();
            label7 = new Label();
            numericUpDown6 = new NumericUpDown();
            numericUpDown7 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 502);
            button1.Name = "button1";
            button1.Size = new Size(189, 58);
            button1.TabIndex = 0;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(405, 336);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(539, 224);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Location = new Point(405, 313);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Result:";
            label1.Visible = false;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = Color.White;
            richTextBox2.Location = new Point(405, 47);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(539, 252);
            richTextBox2.TabIndex = 4;
            richTextBox2.Text = "";
            richTextBox2.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Location = new Point(405, 23);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 5;
            label2.Text = "Items:";
            label2.Visible = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(165, 29);
            numericUpDown1.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 27);
            numericUpDown1.TabIndex = 7;
            numericUpDown1.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 27);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 8;
            label3.Text = "Seed:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 62);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 10;
            label4.Text = "Items count:";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(165, 62);
            numericUpDown2.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 27);
            numericUpDown2.TabIndex = 9;
            numericUpDown2.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 95);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 12;
            label5.Text = "Capacity:";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(165, 95);
            numericUpDown3.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(93, 27);
            numericUpDown3.TabIndex = 11;
            numericUpDown3.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // numericUpDown4
            // 
            numericUpDown4.Location = new Point(165, 128);
            numericUpDown4.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(93, 27);
            numericUpDown4.TabIndex = 13;
            numericUpDown4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(258, 128);
            numericUpDown5.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(93, 27);
            numericUpDown5.TabIndex = 14;
            numericUpDown5.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 133);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 15;
            label6.Text = "Weight(min,max):";
            // 
            // button2
            // 
            button2.Location = new Point(207, 502);
            button2.Name = "button2";
            button2.Size = new Size(189, 58);
            button2.TabIndex = 16;
            button2.Text = "Hide";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 168);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 19;
            label7.Text = "Value(min,max):";
            // 
            // numericUpDown6
            // 
            numericUpDown6.Location = new Point(258, 163);
            numericUpDown6.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown6.Name = "numericUpDown6";
            numericUpDown6.Size = new Size(93, 27);
            numericUpDown6.TabIndex = 18;
            numericUpDown6.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // numericUpDown7
            // 
            numericUpDown7.Location = new Point(165, 163);
            numericUpDown7.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDown7.Name = "numericUpDown7";
            numericUpDown7.Size = new Size(93, 27);
            numericUpDown7.TabIndex = 17;
            numericUpDown7.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(958, 597);
            Controls.Add(label7);
            Controls.Add(numericUpDown6);
            Controls.Add(numericUpDown7);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(label5);
            Controls.Add(numericUpDown3);
            Controls.Add(label4);
            Controls.Add(numericUpDown2);
            Controls.Add(label3);
            Controls.Add(numericUpDown1);
            Controls.Add(label2);
            Controls.Add(richTextBox2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
        private Label label1;
        private RichTextBox richTextBox2;
        private Label label2;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDown2;
        private Label label5;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
        private Label label6;
        private Button button2;
        private Label label7;
        private NumericUpDown numericUpDown6;
        private NumericUpDown numericUpDown7;
    }
}
