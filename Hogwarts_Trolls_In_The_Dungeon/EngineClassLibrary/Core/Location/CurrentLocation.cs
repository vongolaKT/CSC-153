using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Location
{
    public class CurrentLocation
    {
        //TODO Current Location
        public static int playerPos = 0;

        public static void DisplayCurrentLocation()
        {
            Console.WriteLine($"Current location : {EngineClassLibrary.Core.Location.Rooms.Room[playerPos]}");
        }
    }
}
