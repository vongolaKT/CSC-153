using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Location
{
    public class Rooms
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Exits { get; set; }

        public Rooms(string name, string description, string exits)
        {
            Name = name;
            Description = description;
            Exits = exits;

        }

        public static List<Rooms> rooms = new List<Rooms>(); // {"Hogwart's Express", "Lake", "Entrance Hall", "Dungeons", "Common Room" };

    }
}
