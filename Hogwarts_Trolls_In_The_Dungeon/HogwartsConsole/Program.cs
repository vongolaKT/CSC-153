using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EngineClassLibrary;

/**
* 3/21/2021
* CSC 153
* Kevin Griffin
* Making Player, Rooms and Enemies into Objects to hold more information.
*/

namespace HogwartsConsole
{
    class Program
    {
        // TODO Figure out how to make it so I do not have to use the full path in the class library every time I want to access or call something.... This hasn't occured before...
        static void Main(string[] args)
        {
            // Make console view stretch to whole screen, for explanation go to ConsoleView
            ConsoleView.Maximize();

            // Build all lists and world items
            EngineClassLibrary.Core.ListBuilder.Build();

            // Introduction
            // This is also where player construction logic is sent through. Currently saving and loading is not supported.
            EngineClassLibrary.Create_Save_Load.Introduction.Welcome();


            //Main menu

            while (EngineClassLibrary.Commands.Command.exit == false)
            {
                EngineClassLibrary.Core.StandardMessages.DisplayLocation();
                EngineClassLibrary.Core.StandardMessages.DisplayMenu();

                string input = Console.ReadLine();
                
                // ignore whitespace
                if (string.IsNullOrWhiteSpace(input))
                {
                    continue;
                }

                EngineClassLibrary.Commands.Command.CheckInput(ref input);


                Console.ForegroundColor = ConsoleColor.DarkCyan;                                        // Changes the color before getting information back from Command Selection

                EngineClassLibrary.Commands.Command.CommandSelection(input);
            }
        }
    }
}
