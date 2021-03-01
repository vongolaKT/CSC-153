using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Commands
{
    public class HelpFile
    {
        public static void DisplayHelpInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Available commands                     ");
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine("North - Move North                     ");
            Console.WriteLine("South - Move South                     ");
            Console.WriteLine("Attack - Deal Damage                   ");
            Console.WriteLine("Exit - Exit the Game                   ");
            Console.WriteLine("Rooms - Displays Rooms                 ");
            Console.WriteLine("Items - Displays Items                 ");
            Console.WriteLine("Spells - Displays Spells               ");
            Console.WriteLine("Potions - Displays Potions             ");
            Console.WriteLine("Enemies - Displays Enemies             ");
            Console.WriteLine("Money - Displays Currency              ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
