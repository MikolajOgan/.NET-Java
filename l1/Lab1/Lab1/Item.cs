namespace Lab1
{
    internal class Item
    {
        int value;
        int weight;
        int n;
        float ratio;

        public Item(int value, int weight, int n)
        {
            this.value = value;
            this.weight = weight;
            this.n = n;
            this.ratio = (float)value / (float)weight;
        }

        public float get_ratio()
        {
            return this.ratio;
        }

        public int get_value() { return this.value; }
        public int get_weight() { return this.weight; }

        public int get_n() { return this.n; }

        public void set_value(int value) { this.value = value; }

        public void set_weight(int weight) { this.weight = weight; }

        public void set_n(int n) { this.n = n; }

        public override string ToString()
        {
            return "Index: " + this.n + " Value: " + this.value + " Wegiht: " + this.weight + " Ratio: " + this.ratio;
        }

    }
}
