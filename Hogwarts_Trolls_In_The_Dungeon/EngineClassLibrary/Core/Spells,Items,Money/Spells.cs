using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Spells_Items_Money
{
    public class Spells
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public string Description { get; set; }
        public Spells(string name, string attribute, string description)
        {
            Name = name;
            Attribute = attribute;
            Description = description;
        }
        public static List<Spells> Spell = new List<Spells>();   //{ "Stupefy", "Augmenti", "Incendio", "Incarcerous" };
    }
}
