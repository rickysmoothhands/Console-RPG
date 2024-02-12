using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class Enemy : Entity
    {
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
