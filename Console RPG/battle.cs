using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class battle
    {
        public List<Enemy> enemies;
        public bool isResolved;

        public battle(List<Enemy> eniemies)
        {
            this.enemies = enemies;
              this.isResolved = false;
        }


        public void Resolve(List<player> players)
        {
            while (true)
            {// run this code on each of the players
                foreach(var item in players)
                {
                    Console.WriteLine(item.name)
                };
            }
        }








    }
}
