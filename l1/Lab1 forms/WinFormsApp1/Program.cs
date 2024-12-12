namespace Lab1
{
    internal class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());


            Problem p1 = new Problem(10, 5, 1, 10, 1 ,10);
            Console.WriteLine((p1.ToString()));
            p1.solve(20);

            Console.WriteLine((p1.ToString()));
        }
    }
}
