using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    class Location
    {
        public string name;
        public string description;
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
