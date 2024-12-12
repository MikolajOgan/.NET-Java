namespace lab33
{
    public partial class Form2 : Form
    {
        zad2 zad2;
        public Form2(zad2 zad2)
        {
            this.zad2 = zad2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var file = openFileDialog1.FileName;
            if (file != null)
            {
                zad2.img = new Bitmap(file);
                zad2.img1 = new Bitmap(file);
                zad2.img2 = new Bitmap(file);
                zad2.img3 = new Bitmap(file);
                zad2.img4 = new Bitmap(file);
                pictureBox1.Image = zad2.img;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ParallelOptions opt = new ParallelOptions()
            {
                MaxDegreeOfParallelism = 4
            };

            Parallel.For(0, 4, opt, i =>
            {
                if (i == 0)
                {
                    zad2.avg(zad2.img1, pictureBox2);
                }else if (i == 1)
                {
                    zad2.rev(zad2.img2, pictureBox3);
                }else if(i == 2)
                {
                    zad2.remR(zad2.img3, pictureBox4);
                }else
                {
                    zad2.onlB(zad2.img4, pictureBox5);
                }
            });
        }
    }
}
