using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Spells_Items_Money
{
    public class Potions
    {
        public string Name { get; set; }
        public string Effect { get; set; }
        public int Value { get; set; }

        public Potions(string name, string effect, int value)
        {
            Name = name;
            Effect = effect;
            Value = value;
        }

        public static List<Potions> Potion = new List<Potions>(); //{ "Damage", "Sheild" };
    }
}
