namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem p1 = new Problem(10);
            Console.WriteLine((p1.ToString()));
            p1.solve(20);

            Console.WriteLine((p1.ToString()));
        }
    }
}
