using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("TestProject1")]
namespace Lab1

{
    internal class Problem
    {
        int n;
        Random rnd = new Random(5);
        public List<Item> items;
        Result result = null;


        public Problem(int num)
        {
            n = num;
            items = new List<Item>();
            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rnd.Next(1, 20), rnd.Next(1, 20), i));
            }

        }

        public Result solve(int capacity)
        {

            this.items = this.items.OrderByDescending(o => o.get_ratio()).ToList();

            Result res = new Result();
            foreach (var item in items)
            {
                if (res.total_weight + item.get_weight() <= capacity)
                {
                    res.items.Add(item);
                    res.total_weight += item.get_weight();
                    res.total_value += item.get_value();
                }
            }

            this.result = res;
            return res;
        }

        public override string ToString()
        {
            string res = "";
            foreach (Item item in items)
            {
                res += item.ToString() + "\n";
            }

            if (this.result != null)
            {
                res += this.result.ToString();
            }


            return res;
        }

        public Result get_result()
        {
            return this.result;
        }

        public List<Item> get_items()
        {
            return this.items;
        }

        public void set_items(List<Item> items)
        {
            this.items = items;
        }

        public int get_n()
        {
            return this.n;
        }


    }
}
