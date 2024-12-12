namespace lab33
{
    public partial class Form1 : Form
    {
        App app;
        zad2 zad2;
        public Form1(App app, zad2 zad2)
        {
            this.app = app;
            this.zad2 = zad2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            app.base_matrix.fill_matrix();

            richTextBox1.Text = app.base_matrix.ToString();

            richTextBox2.Text = app.multiply_matrix(app.base_matrix, app.base_matrix).ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            app.cores = int.Parse(textBox1.Text.ToString());

            app.base_matrix.fill_matrix();

            richTextBox1.Text = app.base_matrix.ToString();

            richTextBox2.Text = app.multiply_matrix_parallel(app.base_matrix, app.base_matrix).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            app.cores = int.Parse(textBox1.Text.ToString());

            app.base_matrix.fill_matrix();

            richTextBox1.Text = app.base_matrix.ToString();

            richTextBox2.Text = app.thread_multiply(app.base_matrix, app.base_matrix).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            app.cores = int.Parse(textBox1.Text.ToString());

            int size = int.Parse(textBox2.Text.ToString());

            app.base_matrix.fill_matrix(size);

            var watch1 = System.Diagnostics.Stopwatch.StartNew();
            app.thread_multiply(app.base_matrix, app.base_matrix);
            watch1.Stop();



            app.base_matrix.fill_matrix(size);

            var watch2 = System.Diagnostics.Stopwatch.StartNew();
            app.multiply_matrix_parallel(app.base_matrix, app.base_matrix);
            watch2.Stop();



            app.base_matrix.fill_matrix(size);

            var watch3 = System.Diagnostics.Stopwatch.StartNew();
            app.multiply_matrix(app.base_matrix, app.base_matrix);
            watch3.Stop();


            var elapsedMs1 = watch1.ElapsedTicks;
            var elapsedMs2 = watch2.ElapsedTicks;
            var elapsedMs3 = watch3.ElapsedTicks;

            var elapsedMs1_m = watch1.ElapsedMilliseconds;
            var elapsedMs2_m = watch2.ElapsedMilliseconds;
            var elapsedMs3_m = watch3.ElapsedMilliseconds;

            richTextBox3.Text += "Thread time = " + elapsedMs1 + " ms: " + elapsedMs1_m + "\n";
            richTextBox3.Text += "Parallel threads time = " + elapsedMs2 + " ms: " + elapsedMs2_m + "\n";
            richTextBox3.Text += "No threading time = " + elapsedMs3 + " ms: " + elapsedMs3_m + "\n\n";





        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(zad2);
            f2.Show();
        }
    }
}
