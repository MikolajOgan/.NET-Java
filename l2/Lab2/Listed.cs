using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public class Listed
    {
        public List<MonsterResult> Results { get; set; }
    }

    public class MonsterResult
    {
        [Key]
        public string Index { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public override string ToString()
        {
            return $"Index: {Index}\tName: {Name}\tUrl: {Url}\n";
        }

    }
}
