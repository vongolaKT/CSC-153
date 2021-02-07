using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
* 2/6/2021
* CSC 153
* Kevin Griffin
* Beginning of Semester Project: Text Adventure 1
* Adding Arrays - Rooms, Weapons(Spells), Potions, Treasure(Money - galleons, sickles, knuts)
* Adding Lists - Items and Mobs
*/

namespace Hogwarts_Trolls_in_the_Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {

            // Arrays and Lists

            
            string [] Rooms = new string[] {"Hogwart's Express", "Lake", "Entrance Hall", "Dungeons", "Common Room"}; // TODO Make rooms objects? and add more rooms with ability to go west and east.











            // Some usefull variables

            int playerPos = 0;
            

            bool exit = false;

            //Main menu

            while (exit == false)
            {
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("TODO - User prompt");
                Console.WriteLine("1. Display Rooms");
                Console.WriteLine("2. Display Spells");
                Console.WriteLine("3. Display Potion");
                Console.WriteLine("4. Display Money");
                Console.WriteLine("5. Display Items");
                Console.WriteLine("6. Display Enemies");
                Console.WriteLine("7. Exit");
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.Write("Enter a choice > ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        foreach (string index in Rooms)
                        {
                            Console.WriteLine(index);
                        }
                        Console.WriteLine("_______________________________________________");
                        Console.WriteLine("Current Player position is: " + Rooms[playerPos]);
                        break;

                    case "2":
                        // TODO Spells
                        break;

                    case "3":
                        // TODO Potions
                        break;

                    case "4":
                        // TODO Money
                        break;

                    case "5":
                        // TODO Items
                        break;

                    case "6":
                        // TODO Enemies
                        break;

                    case "7":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Not a choice!");
                        break;
                }

            }
        }
    }
}
