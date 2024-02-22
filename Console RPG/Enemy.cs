using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
       public static Enemy goober = new Enemy("sluge", 5, 0, new stats(5, 10, 10, 0), 10);
        public static Enemy SPEIDER = new Enemy("tainted one", 5, 0, new stats(12, 10, 10, 0), 10);
        public static Enemy GOOBLIN = new Enemy("death stalker", 5, 0, new stats(5, 10, 10, 0), 10);
        public static Enemy daemon = new Enemy("The fallen", 5, 0, new stats(5, 10, 10, 15), 10);
        public int xpOnDrop;

        public Enemy(string name, int hp, int mana, stats stats, int xpOnDrop) : base(name, hp, mana, stats)
        {
            this.xpOnDrop = xpOnDrop;

        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            Random random = new Random();
            return targets[random.Next(targets.Count)];
        }
        public void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
        }
    }
}
