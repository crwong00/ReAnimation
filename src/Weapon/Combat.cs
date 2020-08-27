using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReAnimationLibrary
{
    public class Combat
    {
        public static void SaveYourself(Character attacker, Character defender)
        {
            Random rand = new Random();
            int diceRoll = rand.Next(1, 101);
            System.Threading.Thread.Sleep(1065);

            if (diceRoll <= attacker.CalcHitChance() - defender.CalcBlock())
            {
                int damageDealt = attacker.CalcDamage();
                defender.Life -= damageDealt;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("{0} hit {1} for {2} damage!", attacker.Name, defender.Name, damageDealt);

                Console.ResetColor();

            }//end of if 
            else
            {
                Console.WriteLine("{0} missed!", attacker.Name);
            }//end of attacker misses

        }// end of DoAttack

        public static void DoCombat(Character player, Character monster)
        {
            SaveYourself(player, monster);
            if (monster.Life > 0)
            {
                SaveYourself(monster, player);
            }//end of if


        }//end of DoCombat


    }//end of class combat
}

