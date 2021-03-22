using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Commands
{
    class PlayerMove
    {
        
        public static string Move(string direction)
        {
            switch (direction) {

                case "north":
                    if (Core.Location.CurrentLocation.playerPos == 4)
                    {
                        return "Cannot move any further north!";
                        
                    }
                    else
                    {
                        Core.Location.CurrentLocation.playerPos++;
                        return "Moved North!";
                        
                    }
                    
                case "south":
                    if (Core.Location.CurrentLocation.playerPos == 0)
                    {
                        return "Cannot move any further south!";
                        
                    }
                    else
                    {
                        Core.Location.CurrentLocation.playerPos--;
                        return "Moved South!";
                        
                    }
                default:
                    return "Something went wrong :/";
                    
            }
           

            
        }
    }
}
