using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core
{
    public class ListBuilder
    {
        public static void Build()
        {
            // Build Rooms this can later be done from a file or db
            Location.Rooms.rooms.Add(new Location.Rooms("Hogwart's Express", "The train at the front of the school", "North - Lake ||| South - Nothing!"));
            Location.Rooms.rooms.Add(new Location.Rooms("Lake", "Lake in front of the school", "North - Entrance Hall ||| South - Hogwart's Express"));
            Location.Rooms.rooms.Add(new Location.Rooms("Entrance Hall", "Entrance to the school", "North - Dungeons ||| South - Lake"));
            Location.Rooms.rooms.Add(new Location.Rooms("Dungeons", "Dungeons of the school, where many things are kept secret", "North - Common Room ||| South - Entrance Hall"));
            Location.Rooms.rooms.Add(new Location.Rooms("Common Room", "Common Room for students, where you can take shelter!", "North - Nothing! ||| South - Dungeons"));


            // Build Enemies
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Kappa", "Water", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Blast-Ended Skrewt", "Fire", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Dugbog", "Earth", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Nogtail", "Normal", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Mountain Troll", "Normal", 200));

        }
    }
}
