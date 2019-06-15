using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDDO
{
    public class Gearset
    {
        public const int INVENTORY_SLOTS = 11;

        public Item[] items;
        public Stat[] stats;

        public Gearset()
        {
            items = new Item[INVENTORY_SLOTS];
            stats = new Stat[3];
            stats[0] = new Stat("Strength");
            stats[1] = new Stat("Dexterity");
            stats[2] = new Stat("Constitution");
        }
    }
}
