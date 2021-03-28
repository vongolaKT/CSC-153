using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Spells_Items_Money
{
    public class Items
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Items(string name, string description)
        {
            Name = name;
            Description = description;
        }


        public static List<Items> Item = new List<Items>(); //{ "Elder Wand", "Deluminator", "Broomstick", "Gillyweed" };
    }
}
