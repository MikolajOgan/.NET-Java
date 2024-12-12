using System.Windows.Forms;

namespace Lab2
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            textBox3 = new TextBox();
            listBox1 = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(169, 78);
            button1.TabIndex = 1;
            button1.Text = "Get from API";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 96);
            button2.Name = "button2";
            button2.Size = new Size(169, 73);
            button2.TabIndex = 4;
            button2.Text = "Get from DB";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 175);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Index search";
            textBox1.Size = new Size(169, 27);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 208);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Name search";
            textBox2.Size = new Size(169, 27);
            textBox2.TabIndex = 6;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(10, 247);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 191);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(188, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(935, 424);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(1128, 14);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(281, 389);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1129, 409);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Weather enter: city, country";
            textBox3.Size = new Size(280, 27);
            textBox3.TabIndex = 10;
            textBox3.Text = "Wrocław,Poland";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // listBox1
            // 
            listBox1.CausesValidation = false;
            listBox1.ForeColor = SystemColors.InfoText;
            listBox1.Location = new Point(187, 14);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(936, 424);
            listBox1.TabIndex = 11;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1421, 448);
            Controls.Add(listBox1);
            Controls.Add(textBox3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox textBox3;
        private ListBox listBox1;
    }
}