using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core.Player_Enemies
{
    public class Enemies
    {
        public string Name { get; set; }
        public string Attribute { get; set; }
        public int Hp { get; set; }
        public Enemies(string name, string attribute, int hp)
        {
            Name = name;
            Attribute = attribute;
            Hp = hp;
        }

        public static List<Enemies> Enemy = new List<Enemies>();        // { "Kappa" , "Blast-Ended Skrewt" , "Dugbog" , "Nogtail" , "Mountain Troll" };

    }
}
