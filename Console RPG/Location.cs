using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Console_RPG
{
    class Location
    {

        public static Location RuinOftheLostPeopleGate = new Location("the ruins Gate", "where humanity made it it's last stand");
        public static Location BrokenTemple = new Location("ruin temple", "the fallen place of a lost God", new battle(new List<Enemy>() {Enemy.goober}));
        public static Location lostHome = new Location("lost home ", "the space of a abandon family");
        public static Location EntraceToCrpyt = new Location("rusty doors to an old crypt", "what did this door hold behind it");
        public static Location Crpytspassages = new Location("maze like walk ways line with the dead's grave", "this was a place to lay down the dead when they were repected",new battle(new List<Enemy>() {Enemy.SPEIDER}));
        RuinOftheLostPeopleGate.SetNearByLocations(north,losthome,south,west);


        public string name;
        public string description;
        public battle battle;
        public POI interaction;
        public Location north, east, south, west;
        public Location(string name, string description, battle battle = null)
        {
            this.name = name;
            this.description = description;
            this.battle = battle;
        }
        public void SetNearByLocations(Location north = null,Location east = null, Location south = null, Location west = null)
        {
          

            if (!(north is null))
            {
                this.north = north;
                north.south = this;

            }

            if(!(east is null))
            {
                this.east = east;
                east.west = this;
            }

            if(!(south is null))
            {
                this.south = south;
                 south.north = this;
            }

            if (!(west is null))
            {
                this.west = west;
                west.east = this;
            }
            
        }

        public void Resolve()
        {
            Console.WriteLine("You enter " + this.name + ".");
            Console.WriteLine(this.description);

            


            if (!(north is null))
                Console.WriteLine("north " + this.north.name);

            if (!(north is null))
                Console.WriteLine("east " + this.east.name);

            if (!(north is null))
                Console.WriteLine("south " + this.south.name);

            if (!(north is null))
                Console.WriteLine("west " + this.west.name);

            string direction = Console.ReadLine();
            Location nextLocaltion = null;

            if (direction == "north")
                nextLocaltion = this.north;
            else if (direction == "east")
                nextLocaltion = this.east;
            else if (direction == "south")
                nextLocaltion = this.south;
            else if (direction == "west")
                nextLocaltion = this.west;

            nextLocaltion.Resolve();
        }
    }
}
