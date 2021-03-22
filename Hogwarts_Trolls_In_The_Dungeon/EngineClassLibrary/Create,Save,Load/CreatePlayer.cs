using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Create_Save_Load
{
    public class CreatePlayer
    {
        // Add to player list in player class for now later will build from db or file
        public static void CreateNewPlayer()
        {
            string name;
            string classType = "";
            string race = "";
            string password = "";
            int hp = 0;
            bool stopClass = false;
            bool stopRace = false;
            bool stopPassword = false;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("What is your name?");
            Console.Write(">> ");
            name = Console.ReadLine();
            Core.StandardMessages.BreakApartDisplay();
            Console.ResetColor();


            while (stopClass == false)
            {
                Console.WriteLine("What class would you like to have?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Auror - Damage + 30% \nAlchemist - Potion Effectiveness + 20% \nHealer - Healing Magic + 30% \n>> ");
                classType = Console.ReadLine().ToLower();
                Core.StandardMessages.BreakApartDisplay();
                Console.ResetColor();

                if (classType == "auror")
                {
                    // TODO: In damage calculation add 30% to roll and round up if player class == auror
                    stopClass = true;
                }
                else if (classType == "alchemist")
                {
                    // TODO: In the set potion damage and healing add 20% if player class == alchemist
                    stopClass = true;
                }
                else if (classType == "healer")
                {
                    // TODO: In healing calculation add 30% to roll and round up if player class == healer
                    stopClass = true;
                }
                else
                {
                    Console.WriteLine("Not a valid class");
                }

            }

            while (stopRace == false)
            {
                Console.WriteLine("What race would you like to be?");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Human \nHalf-Giant \nGoblin\n>> ");
                race = Console.ReadLine().ToLower();

                Core.StandardMessages.BreakApartDisplay();
                Console.ResetColor();

                if (race == "human")
                {
                    hp = 120;
                    stopRace = true;
                }
                else if (race == "half-giant")
                {
                    hp = 150;
                    stopRace = true;
                }
                else if (race == "goblin")
                {
                    // TODO: maybe add evasion? Else why ever choose anything other than half-giant....
                    hp = 100;
                    stopRace = true;
                }
                else
                {
                    Console.WriteLine("Not a valid Choice!");
                }
            }

            while (stopPassword == false)
            {
                Console.Write("Please create a password \nYour Password must contain a lowercase letter, an uppercase letter, and a special character\n And must also contain 6 characters \n>> ");
                password = Console.ReadLine();

                  // First checks if any index/subscript of the password conatains the specified characters, if it does IndexofAny will return the index which will be higher than -1, if it doesn't it fails
                  // Then checks if any character in the string is an uppercase and then lowercase character using an anonymous function and local variable the will return a value or no value which is seen as true or false
                  // Then finally checks length.... this took forever to get right, I originally started with the .Contains method but would have to do it so many times

                if ((password.IndexOfAny("!@#$%^&*?_~-".ToCharArray()) != -1) && password.Any(c => char.IsUpper(c)) && password.Any(c => char.IsLower(c)) && password.Length > 5)
                {
                    stopPassword = true;
                }
                else
                {
                    
                    Console.WriteLine("Your password did not meet requirements");
                    Core.StandardMessages.BreakApartDisplay();
                }

            }

            Core.Player_Enemies.Player.players.Add(new Core.Player_Enemies.Player(name, password, classType, race, hp));
        }

    }
}
