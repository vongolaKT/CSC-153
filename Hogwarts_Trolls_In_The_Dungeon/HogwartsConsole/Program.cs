using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineClassLibrary;

/**
* 2/28/2021
* CSC 153
* Kevin Griffin
* Refactoring of original Text Adventure and added Attacks, also added structure for future expansion as I would like to use this branch exclusively
*/

namespace HogwartsConsole
{
    class Program
    {
        // TODO Figure out how to make it so I do not have to use the full path in the class library every time I want to access or call something.... This hasn't occured before...
        static void Main(string[] args)
        {
            
            bool exit = false;

            //Main menu
            
            while (exit == false)
            {
                MainMenu();

                string input = Console.ReadLine();
                
                // ignore whitespace
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                // make input case insensitive
                string insensitiveInput = input.ToLower();

               

                if (insensitiveInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting!");
                    break;
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;                                        // Changes the color before getting information back from 

                EngineClassLibrary.Commands.Command.CommandSelection(insensitiveInput);
            }
        }
        public static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Cyan;
            EngineClassLibrary.Core.Location.CurrentLocation.DisplayCurrentLocation();


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Type 'Help' to see a list of commands");
            Console.WriteLine("");

            Console.WriteLine("1. Move North");
            Console.WriteLine("2. Move South");
            Console.WriteLine("3. Attack");
            Console.WriteLine("4. Exit");
            Console.WriteLine("________________________________________________________________________________________________________________________");
            Console.WriteLine("Current Location: ");
            Console.WriteLine("");
            Console.Write("Enter a choice > ");
        }
    }
}
