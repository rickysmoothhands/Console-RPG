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

        public void ClassPick()
        {// Player picks From fighter ,mage ,cleric
             CharClass = Console.ReadLine();
            if (CharClass == "FIGHTER")
            {
                CharClass = "FIGHTER";
                Console.WriteLine("You were train in the blade, saddly that will only keep you alive longer");

            }
            else if (CharClass == "MAGE")
            {
                CharClass = "MAGE";
                Console.WriteLine("tomes and scroll fill your mind, all this knowlege soon to be lost");
            }
            else if (CharClass == "CLERIC")
            {
                CharClass = "CLERIC";
                Console.WriteLine("the essence of the gods stay with you, but they will not save you");
            }
            else
            {
                Console.WriteLine("Life cant be unlived, choose your past");
                Console.WriteLine("|FIGHTER| |MAGE| |CLERIC|");
            }              ClassPick();
            }

            public override void DoTurn(List<player> players, List<Enemy> enemies)
        {

            Entity target = ChooseTarget(enemies);
        }






}
}
    
