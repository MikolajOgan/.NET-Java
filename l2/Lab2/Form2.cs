using System.Timers;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        App app;
        bool fromDatabase = true;
        List<MonsterResult> allResultsCopy = null;

        public Form2(App app)
        {
            InitializeComponent();
            this.app = app;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = listBox1.Items;
            app.api.getAll(listBox1);
            this.fromDatabase = false;

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                string[] lines = listBox1.SelectedItem.ToString().Split('\n', StringSplitOptions.RemoveEmptyEntries);

                MonsterResult monster = new MonsterResult();

                foreach (string line in lines)
                {
                    string[] components = line.Split('\t', StringSplitOptions.RemoveEmptyEntries);

                    foreach (string component in components)
                    {
                        if (component.Contains("Index"))
                        {
                            string index = component.Trim().Split(':')[1].Trim();
                            monster.Index = index;
                        }
                        else if (component.Contains("Name"))
                        {
                            string name = component.Trim().Split(':')[1].Trim();
                            monster.Name = name;
                        }
                        else if (component.Contains("Url"))
                        {
                            string url = component.Trim().Split(':')[1].Trim();
                            monster.Url = url;
                        }

                    }
                }

                if (!fromDatabase)
                {
                    Form1 form1 = new Form1(app, monster);
                    form1.Show();
                }
                else
                {
                    DBmonster form = new DBmonster(app, monster);
                    form.Show();
                }

            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            app.api.getClock(pictureBox1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            app.api.getWeather(pictureBox3, textBox3.Text.ToString());

            app.api.getClock(pictureBox1);

            listBox1.DataSource = app.db.monsterResults.ToList();

            System.Timers.Timer timer = new System.Timers.Timer(10000);

            timer.Elapsed += OnTimedEvent;

            timer.AutoReset = true;

            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.DataSource = app.db.monsterResults.ToList();
            this.fromDatabase = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (fromDatabase)
            {
                listBox1.DataSource = app.db.monsterResults.ToList();
            }
            else if (this.allResultsCopy != null)
            {
                listBox1.DataSource = null;

                listBox1.Items.AddRange(this.allResultsCopy.ToArray());
            }
            else
            {
                this.allResultsCopy = listBox1.Items.Cast<MonsterResult>().ToList();
            }


            string searchTerm = textBox1.Text.ToLower();

            List<MonsterResult> allResults = listBox1.Items.Cast<MonsterResult>().ToList();

            IEnumerable<MonsterResult> matchingItems = allResults.Where(item => item.Index.ToLower().Contains(searchTerm));


            if (!matchingItems.Any())
            {
                app.api.noResults(pictureBox2, textBox1.Text);
                pictureBox2.Visible = true;
                pictureBox2.BringToFront();
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox2.SendToBack();
            }

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            listBox1.Items.AddRange(matchingItems.ToArray());
            listBox1.DataSource = listBox1.Items;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (fromDatabase)
            {
                listBox1.DataSource = app.db.monsterResults.ToList();
            }
            else if (this.allResultsCopy != null)
            {
                listBox1.DataSource = null;

                listBox1.Items.AddRange(this.allResultsCopy.ToArray());
            }
            else
            {
                this.allResultsCopy = listBox1.Items.Cast<MonsterResult>().ToList();
            }


            string searchTerm = textBox2.Text.ToLower();

            List<MonsterResult> allResults = listBox1.Items.Cast<MonsterResult>().ToList();

            IEnumerable<MonsterResult> matchingItems = allResults.Where(item => item.Name.ToLower().Contains(searchTerm));

            if (!matchingItems.Any())
            {
                app.api.noResults(pictureBox2, textBox2.Text);
                pictureBox2.Visible = true;
                pictureBox2.BringToFront();
            }
            else
            {
                pictureBox2.Visible = false;
                pictureBox2.SendToBack();
            }

            listBox1.DataSource = null;
            listBox1.Items.Clear();

            listBox1.Items.AddRange(matchingItems.ToArray());
            listBox1.DataSource = listBox1.Items;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            app.api.getWeather(pictureBox3, textBox3.Text.ToString());
        }


    }
}
