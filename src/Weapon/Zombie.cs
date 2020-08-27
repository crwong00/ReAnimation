using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReAnimationLibrary
{
    public class Zombie : Character
    {
        private int _minDamage;

        public string Description { get; set; }
        public int MaxDamage { get; set; }
        public int MaxLife { get; set; }


        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = (value > 0 && value <= MaxDamage) ? value : 0;

            }
        }//end of MinDamage

        public Zombie(string name, int hitChance, int block, int life, int maxLife, string description, int minDamage, int maxDamage) : base(name, hitChance, block, life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;

        }

        public override string ToString()
        {
            return string.Format("{0}\n{1}\n{2} life\n Hits for up to {3} damage.",
                Name,
                Description,
                Life,
                MaxDamage);
        }

        public override int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage);
        }
    }
}
