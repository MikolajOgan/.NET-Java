using Newtonsoft.Json;
using System.Windows.Forms;

namespace Lab2
{
    public partial class API
    {
        private HttpClient client;


        public async void getData(PictureBox imageBox, RichTextBox textBox, string creatureID, App app)
        {
            try
            {
                string call = "https://www.dnd5eapi.co/api/monsters/" + creatureID;
                string response = await client.GetStringAsync(call);
                Creature deserializedObject = JsonConvert.DeserializeObject<Creature>(response);
                textBox.Text = deserializedObject.ToString();
                app.db.addCreature(deserializedObject);

                getImage(imageBox, creatureID);
            }
            catch
            {
                say(imageBox, "Can't find", creatureID, "innocent");
            }
        }

        public async void getAll(ListBox list)
        {
            try
            {
                string call = "https://www.dnd5eapi.co/api/monsters/";
                string response = await client.GetStringAsync(call);
                Listed deserializedObject = JsonConvert.DeserializeObject<Listed>(response);

                List<object> items = new List<object>();


                foreach (MonsterResult x in deserializedObject.Results)
                {
                    items.Add(x);
                }

                list.DataSource = items;

            }
            catch
            {

            }
        }



        public async void getClock(PictureBox pictureBox)
        {
            try
            {
                string call = "https://dragon.best/api/clock.png?flip=on";
                pictureBox.Load(call);
            }
            catch
            {

            }
            
        }

        public async void noResults(PictureBox pictureBox, string querry)
        {
            try
            {
                string call = $"https://dragon.best/api/glax_says.png?text={querry}&bottom_text=not found&background=&font=&colorize=&width=&rainbow=0&face=not-sure-if";
                pictureBox.Load(call);
            }
            catch
            {

            }
            
        }

        public async void say(PictureBox pictureBox, string querry1, string querry2, string face)
        {
            try
            {
                string call = $"https://dragon.best/api/glax_says.png?text={querry1}&bottom_text={querry2}&background=&font=&colorize=&width=&rainbow=0&face={face}";
                pictureBox.Load(call);
            }
            catch
            {

            }
            
        }
        public async void getWeather(PictureBox pictureBox, string querry)
        {
            try
            {
                string call = $"https://dragon.best/api/glax_weather.png?location={querry}&lon=&lat=&units=metric&forecast=on";
                pictureBox.Load(call);
            }
            catch
            {

            }
            
        }

        public async void getImage(PictureBox pictureBox, string id)
        {
            try
            {
                string call = $"https://www.dnd5eapi.co/api/images/monsters/{id}.png";
                pictureBox.Load(call);
            }
            catch
            {
                say(pictureBox, "No image for", id, "laughing");
            }
        }

        public async void getImageResult(PictureBox pictureBox, Creature monster)
        {
            try
            {
                string call = $"https://dragon.best/api/certificate.png?title={monster.Name}&text={monster.Type}\n{monster.Size}\nHD: {monster.Hit_dice}\nHP: {monster.Hit_points}";
                pictureBox.Load(call);
            }
            catch
            {

            }

        }

        public API()
        {
            client = new HttpClient();
        }
    }
}