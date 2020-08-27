using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReAnimationLibrary
{
    public class Weapon
    {
        public string Name { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public bool IsRanged { get; set; }

        public Weapon() { }

        public Weapon(string name, int minDamage, int maxDamage, bool isRanged)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            IsRanged = IsRanged;
        }


        public override string ToString()
        {
            return string.Format("{0}\n that deals {1} - {2} dmg ",
                Name,
                MinDamage,
                MaxDamage);
        }

    }
}
