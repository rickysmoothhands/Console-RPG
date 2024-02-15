using System;

namespace Console_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("in a land groaning with the sins of the ages finally the it has drawn it's last breath");
            Console.WriteLine("It has suffocated under this pain.");
            Console.WriteLine("while the world has found peace from it's suffering, you have not.");
            Console.WriteLine("what where you before before the lands went silent.");
            Console.WriteLine("|FIGHTER| |MAGE| |CLERIC|");
          
            player player1 = new player("josh" , 10, 10, new stats(10,10,10,10),1, "fighter");
            player1.ClassPick();
           Enemy goober = new Enemy("sluge", 5, 0, new stats(5, 10, 10, 0),10);
            Enemy SPEIDER = new Enemy("tainted one", 5, 0, new stats(12, 10, 10, 0), 10);
            Enemy GOOBLIN = new Enemy("death stalker", 5, 0, new stats(5, 10, 10, 0), 10);
            Enemy daemon = new Enemy("The fallen", 5, 0, new stats(5, 10, 10, 15), 10);


            Location RuinOTtheLostPeopleGate = new Location("the ruins Gate", "where humanity made it it's last stand");
            Location BrokenTemple = new Location("ruin temple", "the fallen place of a lost God");
            Location lostHome = new Location("lost home ", "the space of a abandon family");
            Location EntraceToCrpyt = new Location("rusty doors", "what did this door hold behind it");

        }
    }
}
