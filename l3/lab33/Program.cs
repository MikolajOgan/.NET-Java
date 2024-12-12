namespace lab33
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            App app = new App();
            zad2 zad2 = new zad2();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(app, zad2));
        }
    }
}