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
                    Console.WriteLine("");
                    Console.WriteLine("Rooms:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string room in EngineClassLibrary.Core.Location.Rooms.Room)
                    {
                        Console.WriteLine(room);
                    }
                    Console.WriteLine("_______________________________________________");

                    break;

                case "spells":
                    Console.WriteLine("");
                    Console.WriteLine("Spells:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string spell in EngineClassLibrary.Core.Spells_Items_Money.Spells.Spell)
                    {
                        Console.WriteLine(spell);
                    }
                    break;

                case "potions":
                    Console.WriteLine("");
                    Console.WriteLine("Potions:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string potion in Core.Spells_Items_Money.Potions.Potion)
                    {
                        Console.WriteLine(potion);
                    }
                    break;

                case "money":
                    Console.WriteLine("");
                    Console.WriteLine("Money:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string money in Core.Spells_Items_Money.Money.Moneys)
                    {
                        Console.WriteLine(money);
                    }
                    break;

                case "items":
                    Console.WriteLine("");
                    Console.WriteLine("Items:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string item in Core.Spells_Items_Money.Items.Item)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case "enemies":
                    Console.WriteLine("");
                    Console.WriteLine("Enemies:");
                    Console.WriteLine("_______________________________________________");
                    foreach (string enemy in Core.Player_Enemies.Enemies.Enemy)
                    {
                        Console.WriteLine(enemy);
                    }
                    break;

                case "north":
                    string outputNorth = EngineClassLibrary.Commands.PlayerMove.Move("north");
                    Console.WriteLine(outputNorth);
                    break;

                case "south":
                    string outputSouth = EngineClassLibrary.Commands.PlayerMove.Move("south");
                    Console.WriteLine(outputSouth);
                    break;
                case "attack":
                    int damage = EngineClassLibrary.Commands.Attack.AttackDamage();
                    Console.WriteLine($"Damage Dealt to enemy : {damage}");
                    break;
                case "help":
                    HelpFile.DisplayHelpInfo();
                    break;
                default:
                    Console.WriteLine("Not a choice!");
                    break;
            }
        }
    }   
}
