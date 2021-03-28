using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Spells_Items_Money
{
    public class Money
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Money(string name, string description)
        {
            Name = name;
            Description = description;
        }


        public static List<Money> Moneys = new List<Money>(); // "Galleon(s)", "Sickle(s)", "Knut(s)" };
    }
}
