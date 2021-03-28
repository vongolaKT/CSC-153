using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Commands
{
    public static class Command
    {
        public static void CommandSelection(string input)
        {
            switch (input)
            {
                case "rooms":
                    Core.StandardMessages.ViewAfterChoice("Rooms");
                    foreach (Core.Location.Rooms room in Core.Location.Rooms.rooms)
                    {
                        Console.WriteLine(room.Name);
                    }
                    Console.WriteLine("_______________________________________________");

                    break;

                case "spells":
                    Core.StandardMessages.ViewAfterChoice("Spells");
                    foreach(Core.Spells_Items_Money.Spells spell in Core.Spells_Items_Money.Spells.Spell)
                    {
                        Console.WriteLine(spell.Name);
                    }
                    break;

                case "potions":
                    Core.StandardMessages.ViewAfterChoice("Potions");
                    foreach (Core.Spells_Items_Money.Potions potions in Core.Spells_Items_Money.Potions.Potion)
                    {
                        Console.WriteLine(potions.Name);
                    }
                    break;

                case "money":
                    Core.StandardMessages.ViewAfterChoice("Money");
                    foreach (Core.Spells_Items_Money.Money money in Core.Spells_Items_Money.Money.Moneys)
                    {
                        Console.WriteLine(money.Name);
                    }
                    break;

                case "items":
                    Core.StandardMessages.ViewAfterChoice("Items");
                    foreach (Core.Spells_Items_Money.Items item in Core.Spells_Items_Money.Items.Item)
                    {
                        Console.WriteLine(item.Name);
                    }
                    break;
                   
                case "enemies":
                    Core.StandardMessages.ViewAfterChoice("Enemies");
                    foreach(Core.Player_Enemies.Enemies enemy in Core.Player_Enemies.Enemies.Enemy)
                    {
                        Console.WriteLine(enemy.Name);
                    }
                    break;

                case "north":
                    string outputNorth = PlayerMove.Move("north");
                    Console.WriteLine(outputNorth);
                    break;

                case "south":
                    string outputSouth = PlayerMove.Move("south");
                    Console.WriteLine(outputSouth);
                    break;
                case "attack":
                    int damage = Attack.AttackDamage();
                    Console.WriteLine($"Damage Dealt to enemy : {damage}");
                    break;
                case "help":
                    HelpFile.DisplayHelpInfo();
                    break;
                case "exit":
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Exiting!");
                    exit = true;
                    break;
                default:
                    Core.StandardMessages.ChoiceError();
                    break;
            }
        }

        public static string CheckInput(ref string input)
        {
            // make input case insensitive
            input = input.ToLower();

            return input;
        }

        public static bool exit = false;
    }   
}
