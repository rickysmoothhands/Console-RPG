using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {

        public static Location RuinOTtheLostPeopleGate = new Location("the ruins Gate", "where humanity made it it's last stand");
        public static Location BrokenTemple = new Location("ruin temple", "the fallen place of a lost God");
        public static Location lostHome = new Location("lost home ", "the space of a abandon family", new Shop("heilron", "broken bones" ,new List<Item>() { Item.potion1 }));
        public static Location EntraceToCrpyt = new Location("rusty doors", "what did this door hold behind it");

        public string name;
        public string description;
        public POI interaction;
        public Location north, east, south, west;
        public Location(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public void SetNearByLocations(Location north = null,Location east = null, Location south = null, Location west = null)
        {
            this.north = north;
            this.east = east; 
            this.south = south;
            this.west = west;

            if (!(north is null ))
            north.south = this;

            if(!(east is null))
            east.west = this;

            if(!(south is null))
            south.north = this;

            if (!(west is null))
                west.east = this;
            
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
