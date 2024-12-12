using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            label3.Visible = true;
            richTextBox1.Visible = true;
            richTextBox2.Visible = true;

            if((int)numericUpDown6.Value < (int)numericUpDown7.Value)
            {
                int swap;
                swap = (int)numericUpDown6.Value;
                numericUpDown6.Value = numericUpDown7.Value;
                numericUpDown7.Value = swap;
            }

            if ((int)numericUpDown5.Value < (int)numericUpDown4.Value)
            {
                int swap;
                swap = (int)numericUpDown5.Value;
                numericUpDown5.Value = numericUpDown4.Value;
                numericUpDown4.Value = swap;
            }

            Problem p1 = new Problem((int)numericUpDown2.Value, (int)numericUpDown1.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value, (int)numericUpDown7.Value, (int)numericUpDown6.Value);
            richTextBox2.Text = p1.ToString();

            richTextBox1.Text = p1.solve((int)numericUpDown3.Value).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
            richTextBox1.Visible = false;
            richTextBox2.Visible = false;
        }

    }
}
