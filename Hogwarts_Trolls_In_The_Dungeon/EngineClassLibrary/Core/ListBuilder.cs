using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineClassLibrary.Core
{
    public class ListBuilder
    {
        public static void Build()
        {
            // Build Rooms this can later be done from a file or db
            Location.Rooms.rooms.Add(new Location.Rooms("Hogwart's Express", "The train at the front of the school", "North - Lake ||| South - Nothing!"));
            Location.Rooms.rooms.Add(new Location.Rooms("Lake", "Lake in front of the school", "North - Entrance Hall ||| South - Hogwart's Express"));
            Location.Rooms.rooms.Add(new Location.Rooms("Entrance Hall", "Entrance to the school", "North - Dungeons ||| South - Lake"));
            Location.Rooms.rooms.Add(new Location.Rooms("Dungeons", "Dungeons of the school, where many things are kept secret", "North - Common Room ||| South - Entrance Hall"));
            Location.Rooms.rooms.Add(new Location.Rooms("Common Room", "Common Room for students, where you can take shelter!", "North - Nothing! ||| South - Dungeons"));


            // Build Enemies
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Kappa", "Water", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Blast-Ended Skrewt", "Fire", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Dugbog", "Plant", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Nogtail", "Normal", 100));
            Player_Enemies.Enemies.Enemy.Add(new Player_Enemies.Enemies("Mountain Troll", "Normal", 200));

            // Build Spells
            Spells_Items_Money.Spells.Spell.Add(new Spells_Items_Money.Spells("Incendio", "Fire", "Shoots a blast of fire fromyour wand."));
            Spells_Items_Money.Spells.Spell.Add(new Spells_Items_Money.Spells("Augmenti", "Water", "Shoots a jet of water from the tip of your wand."));
            Spells_Items_Money.Spells.Spell.Add(new Spells_Items_Money.Spells("Incarcerous", "Plant", "Using this spell causes vines to erupt from the ground hitting and grabbing at the target."));
            Spells_Items_Money.Spells.Spell.Add(new Spells_Items_Money.Spells("Stupefy", "Normal", "A "));

            // Build Items
            Spells_Items_Money.Items.Item.Add(new Spells_Items_Money.Items("Elder Wand", "Increases damage by 20 for all spells."));
            Spells_Items_Money.Items.Item.Add(new Spells_Items_Money.Items("Deluminator", ""));
            Spells_Items_Money.Items.Item.Add(new Spells_Items_Money.Items("Broomstick", "Can be used to fly around the castle at will"));
            Spells_Items_Money.Items.Item.Add(new Spells_Items_Money.Items("Gillyweed", "Usefull around water."));

            // Build Money
            Spells_Items_Money.Money.Moneys.Add(new Spells_Items_Money.Money("Galleon(s)", "1 Galleon is worth 17 Sickles."));
            Spells_Items_Money.Money.Moneys.Add(new Spells_Items_Money.Money("Sickle(s)", "1 Sickle is worth 29 Knuts."));
            Spells_Items_Money.Money.Moneys.Add(new Spells_Items_Money.Money("Knut(s)", "Lowest value of wizard Money."));

            // Build Potions
            Spells_Items_Money.Potions.Potion.Add(new Spells_Items_Money.Potions("Damage", "Deals a set amount of damage to an enemy.", 40));
            Spells_Items_Money.Potions.Potion.Add(new Spells_Items_Money.Potions("Shield", "Gives character an extra shield on top of health.", 40));
        }
    }
}
