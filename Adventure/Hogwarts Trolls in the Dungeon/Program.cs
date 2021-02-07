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

            string [] Spells = new string[] { "Stupefy", "Augmenti", "Incendio", "Incarcerous"}; // TODO add spells they also need to be objects









            // Some usefull variables

            int playerPos = 0;
            

            bool exit = false;

            //Main menu

            while (exit == false)
            {
                Console.WriteLine("________________________________________________________________________________________________________________________");
                Console.WriteLine("Enter number or \"n\" to move North or \"s\" to move South");
                Console.WriteLine("1. Rooms");
                Console.WriteLine("2. Spells");
                Console.WriteLine("3. Potions");
                Console.WriteLine("4. Money");
                Console.WriteLine("5. Items");
                Console.WriteLine("6. Enemies");
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
                        foreach (string index in Spells)
                        {
                            Console.WriteLine(index);
                        }
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

                    case "n":
                        if (playerPos == 4)
                        {
                            Console.WriteLine("Cannot move further North!");
                            break;
                        }
                        playerPos++;
                        Console.WriteLine("Current Area: " + Rooms[playerPos]);
                        break;

                    case "s":
                        if (playerPos == 0)
                        {
                            Console.WriteLine("Cannot move further South!");
                            break;
                        }
                        playerPos--;
                        Console.WriteLine("Current Area: " + Rooms[playerPos]);
                        break;

                    default:
                        Console.WriteLine("Not a choice!");
                        break;
                }

            }
        }
    }
}
