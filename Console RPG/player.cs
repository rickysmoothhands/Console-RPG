using System;
using System.Collections.Generic;

namespace Console_RPG
{
    class player : Entity
    {
        public int level;
        public string CharClass;
        public player(string name, int hp, int mana, stats stats, int level, string CharClass): base(name, hp, mana, stats)
        {
            this.level = level;
            this.CharClass = CharClass;
        }

        public override Entity ChooseTarget(List<Entity> targets)
        {
            return targets[0];
        }
        public  void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
        }
    }
}
