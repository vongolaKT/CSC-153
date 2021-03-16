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
                    foreach (string room in EngineClassLibrary.Core.Location.Rooms.Room)
                    {
                        Console.WriteLine(room);
                    }
                    Console.WriteLine("_______________________________________________");

                    break;

                case "spells":
                    Core.StandardMessages.ViewAfterChoice("Spells");
                    LoopThroughList(Core.Spells_Items_Money.Spells.Spell);
                    break;

                case "potions":
                    Core.StandardMessages.ViewAfterChoice("Potions");
                    LoopThroughList(Core.Spells_Items_Money.Potions.Potion);
                    break;

                case "money":
                    Core.StandardMessages.ViewAfterChoice("Money");
                    LoopThroughList(Core.Spells_Items_Money.Money.Moneys);
                    break;

                case "items":
                    Core.StandardMessages.ViewAfterChoice("Items");
                    LoopThroughList(Core.Spells_Items_Money.Items.Item);
                    break;

                case "enemies":
                    Core.StandardMessages.ViewAfterChoice("Enemies");
                    LoopThroughList(Core.Player_Enemies.Enemies.Enemy);
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
                default:
                    Core.StandardMessages.ChoiceError();
                    break;
            }
        }


        public static void LoopThroughList(List<string> input)
        {
            foreach(string item in input)
            {
                Console.WriteLine(item);
            }
        }
    }   
}
