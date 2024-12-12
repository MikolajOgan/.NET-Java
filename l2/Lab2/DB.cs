using Microsoft.EntityFrameworkCore;

namespace Lab2
{
    public class DB : DbContext
    {
        public DbSet<Creature> creatures { get; set; }
        public DbSet<MonsterResult> monsterResults { get; set; }
        public DB()
        {
            Database.EnsureCreated();
           
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source = Univ5.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public void addMonsterResult(MonsterResult monsterResult)
        {
            MonsterResult existingMonsterResult = monsterResults.Find(monsterResult.Index);

            if (existingMonsterResult != null)
            {
                monsterResults.Remove(existingMonsterResult);
            }

            monsterResults.Add(monsterResult);

            SaveChanges();

        }

        public void addCreature(Creature creature)
        {
            Creature existingCreature = creatures.Find(creature.Index);

            if (existingCreature != null)
            {
                creatures.Remove(existingCreature);
            }
            creatures.Add(creature);

            SaveChanges();

        }

        public Creature GetCreatureByIndex(string index)
        {
            return creatures.Find(index);
        }

    }
}
