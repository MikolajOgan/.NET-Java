using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Tests1")]
namespace Lab1

{
    internal class Problem
    {
        int n;
        Random rnd;
        public List<Item> items;
        Result result = null;

        int weight_min;
        int weight_max;
        int value_min;
        int value_max;


        public Problem(int num, int seed, int weight_min, int weight_max, int value_min, int value_max)
        {
            n = num;
            this.weight_min = weight_min;
            this.weight_max = weight_max;
            this.value_min = value_min;
            this.value_max = value_max;
            items = new List<Item>();

            this.rnd= new Random(seed);

            for (int i = 0; i < n; i++)
            {
                items.Add(new Item(rnd.Next(this.value_min, this.value_max), rnd.Next(this.weight_min, this.weight_max), i));
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
