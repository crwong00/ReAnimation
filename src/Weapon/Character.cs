using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReAnimationLibrary
{
    //The abstract keyword indicates that the class is an incomplete implementation, meaning that it is only 
    //intended to be used as a parent to pass info to child classes and will never be instantiated



    public class Character
    {

        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int Life { get; set; }




        public Character
            (string name, int hitChance, int block, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;

        }//end of constructor

        //we will not build a ToString() override here: 
        //1) We won't build any character objects to display
        //2) allows us to build custom ToString() in child classes.

        public virtual int CalcBlock()
        {
            //Making this method virtual gives us the option to override this functionality in child classes. 
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            //This method will give us base functionality to override in children
            return 0;
        }
    }
}
