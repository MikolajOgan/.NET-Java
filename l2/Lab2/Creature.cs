namespace Lab2
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Creature
    {
        [Key]
        public string Index { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Type { get; set; }
        public string Alignment { get; set; }
        public int Hit_points { get; set; }
        public string? Hit_dice { get; set; }
        public string? Hit_points_Roll { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public string Languages { get; set; }
        public float Challenge_rating { get; set; }
        public int Proficiency_bonus { get; set; }
        public int Xp { get; set; }
        public string Url { get; set; }


        public override string ToString()
        {
            return $"Index: {Index}\n" + $"Name: {Name}\n" + $"Size: {Size}\n" + $"Type: {Type}\n" +
                $"Languages: {Languages}\n" +
                $"Hp: {Hit_points}\n" +
                $"HitDice: {Hit_dice}\n" +
                $"Dex: {Dexterity}\n" +
                $"Con {Constitution}\n" +
                $"Int: {Intelligence}\n" +
                $"Wis: {Wisdom}\n" +
                $"Cha: {Charisma}\n";
        }

    }
}
