using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class DBmonster : Form
    {
        App app;
        private MonsterResult monster;
        public DBmonster(App app, MonsterResult monster)
        {
            InitializeComponent();
            this.app = app;
            this.monster = monster;
        }

        private void DBmonster_Load(object sender, EventArgs e)
        {

            Creature creatures = app.db.GetCreatureByIndex(this.monster.Index);

            richTextBox1.Text = creatures.ToString();

            app.api.getImageResult(pictureBox1, creatures);

        }

    }
}
