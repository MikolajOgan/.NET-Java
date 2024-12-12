namespace Lab1
{
    internal class Result
    {
        public int total_weight;
        public int total_value;
        public List<Item> items;
        public Result()
        {
            this.total_weight = 0;
            this.total_value = 0;
            this.items = new List<Item>();
        }

        public override string ToString()
        {
            string res = "Total weight: " + this.total_weight + " Total_value: " + this.total_value + "\nItems:\n";
            foreach (Item item in items)
            {
                res += item.ToString() + "\n";
            }

            return res;
        }
    }
}
