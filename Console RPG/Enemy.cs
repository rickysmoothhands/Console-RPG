using System;
using System.Collections.Generic;
using System.Linq;

namespace Console_RPG
{
    class Enemy : Entity
    {
        public static Enemy goober = new Enemy("sluge", 5, 0, new stats(5, 10, 10, 0), 10);
        public static Enemy SPEIDER = new Enemy("tainted one", 5, 0, new stats(12, 10, 10, 0), 10);
        public static Enemy GOOBLIN = new Enemy("death stalker", 5, 0, new stats(5, 10, 10, 0), 10);
        public static Enemy daemon = new Enemy("The fallen", 5, 0, new stats(5, 10, 10, 15), 10);
        public int coreOnDrop;

        public Enemy(string name, int hp, int mana, stats stats, int coreOnDrop) : base(name, hp, mana, stats)
        {
            this.coreOnDrop = coreOnDrop;

        }

        public override Entity ChooseTarget(List<Entity> choices)
        {
            Random random = new Random();


            for (int i = 0; i < choices.Count; i++)
            {
                Console.WriteLine(choices[i]).name);
            



            int index = Convert.ToInt32(Console.ReadLine());
            return choices[Index]
            return choices[random.Next(0, choices.Count)];
      

        }
        
        public override void Attack(Entity target)
        {
            Console.WriteLine(this.name + "attacked" + target.name + "!");
        }

        public override void DoTurn(List<player> players, List<Enemy> enemies)
        {

            Entity target = ChooseTarget(players.Cast<Entity>().ToList());
            Attack(target);
        }
    }
}
