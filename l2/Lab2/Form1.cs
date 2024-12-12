
using System.Timers;

namespace Lab2
{
    public partial class Form1 : Form
    {
        App app;
        MonsterResult monster;

        public Form1(App app, MonsterResult monster)
        {
            InitializeComponent();
            this.app = app;
            this.monster = monster;
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            app.api.getClock(pictureBox1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            app.api.getClock(pictureBox1);

            app.api.getData(pictureBox2, richTextBox1, monster.Index, this.app);
            app.db.addMonsterResult(monster);

            System.Timers.Timer timer = new System.Timers.Timer(10000);

            timer.Elapsed += OnTimedEvent;

            timer.AutoReset = true;

            timer.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            app.api.getData(pictureBox2, richTextBox1, textBox1.Text.ToString(), this.app);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
