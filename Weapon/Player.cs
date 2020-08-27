using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReAnimationLibrary
{
    public class Player : Character
    {
        public Weapon EquippedWeapon { get; set; }
        public PlayerClass Occupation { get; set; }
        private int _minDamage;

        public int MaxDamage { get; set; }


        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                _minDamage = (value > 0 && value <= MaxDamage) ? value : 0;

            }
        }//end of MinDamage

        public Player(string name, PlayerClass occupation, Weapon equippedWeapon, int hitChance, int block, int life, int minDamage, int maxDamage) : base(name, hitChance, block, life)
        {
            Name = name;
            Occupation = occupation;
            EquippedWeapon = equippedWeapon;
            HitChance = hitChance;
            Block = block;
            Life = life;
            MaxDamage = maxDamage;
            MinDamage = minDamage;

            switch (occupation)
            {
                case PlayerClass.PoliceOfficer:
                    HitChance -= 20;
                    block -= 20;
                    Life = 25;
                    MaxDamage -= 35;
                    break;
                case PlayerClass.Military:
                    HitChance += 20;
                    block += 20;
                    MinDamage += 30;
                    break;
                case PlayerClass.Doctor:
                    Life += 45;
                    break;
                case PlayerClass.Engineer:
                    Block -= 20;
                    break;
                case PlayerClass.Constructionworker:
                    break;
                case PlayerClass.ScaredChild:
                    HitChance = 0;
                    Block = 0;
                    life = 1;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} \nLife: {1} \nHit Chance: {2}%\n block: {3}%\nWeapon: {4}",
            Name,
            Life,
            HitChance,
            Block,
            EquippedWeapon);
        }

        public override int CalcDamage()
        {
            return new Random().Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
        }

        public override int CalcHitChance()
        {
            return HitChance;
        }


    }
}


