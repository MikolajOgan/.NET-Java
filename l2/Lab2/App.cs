namespace Lab2
{
    public class App
    {
        public DB db;
        public API api;
        public App()
        {
            db = new DB();
            api = new API();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form2(this));
        }
    }
}
