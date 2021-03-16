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
                    if (EngineClassLibrary.Core.Location.CurrentLocation.playerPos == 4)
                    {
                        return "Cannot move any further north!";
                        
                    }
                    else
                    {
                        EngineClassLibrary.Core.Location.CurrentLocation.playerPos++;
                        return "Moved North!";
                        
                    }
                    
                case "south":
                    if (EngineClassLibrary.Core.Location.CurrentLocation.playerPos == 0)
                    {
                        return "Cannot move any further south!";
                        
                    }
                    else
                    {
                        EngineClassLibrary.Core.Location.CurrentLocation.playerPos--;
                        return "Moved South!";
                        
                    }
                default:
                    return "Something went wrong :/";
                    
            }
           

            
        }
    }
}
