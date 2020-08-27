using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReAnimationLibrary;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the start of the end of your life..... um your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("Alright, " + yourName + " You step outside of your home for the first time in months, after getting fired from your job as a" +
                "\n1) Police Officer" +
                "\n2) Military " +
                "\n3) Doctor" +
                "\n4) Engineer" +
                "\n5) Construction Worker");

            ConsoleKey occupation = Console.ReadKey(true).Key;
            PlayerClass player = PlayerClass.ScaredChild;

            switch (occupation)
            {
                case ConsoleKey.NumPad1:
                case ConsoleKey.P:
                case ConsoleKey.D1:
                    player = PlayerClass.PoliceOfficer;
                    Console.WriteLine("so " + yourName + " was a Police Officer");
                    break;
                case ConsoleKey.NumPad2:
                case ConsoleKey.D2:
                case ConsoleKey.M:
                    player = PlayerClass.Military;
                    Console.WriteLine("So " + yourName + " was in the Military");
                    break;
                case ConsoleKey.NumPad3:
                case ConsoleKey.D3:
                case ConsoleKey.D:
                    player = PlayerClass.Doctor;
                    Console.WriteLine("Quit lying " + yourName + " you were no doctor");
                    break;
                case ConsoleKey.NumPad4:
                case ConsoleKey.D4:
                case ConsoleKey.E:
                    player = PlayerClass.Engineer;
                    Console.WriteLine("So " + yourName + " was an engineer");
                    break;
                case ConsoleKey.NumPad5:
                case ConsoleKey.D5:
                case ConsoleKey.C:
                    player = PlayerClass.Constructionworker;
                    Console.WriteLine("So " + yourName + " was in construction");
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("since you can't decide, you are a scared child " + yourName);
                    break;
            }

            System.Threading.Thread.Sleep(3200);
            Console.ResetColor();
            Console.Clear();

            Console.WriteLine("There is not a soul in sight. No city noises, trash is blowing in the middle of the empty street.");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("Wait, there is a low murmer coming from around the corner.");

            Console.Title = "ReAnimation";

            Weapon machete = new Weapon("machete", 10, 30, false);
            Weapon pistol = new Weapon("pistol", 15, 50, true);
            Weapon machineGun = new Weapon("Machine Gun", 15, 40, true);
            Weapon sharpaxe = new Weapon("Sharp Axe", 15, 40, false);
            Weapon sword = new Weapon("Sword", 20, 50, false);
            Weapon shotgun = new Weapon("Shotgun", 20, 80, true);
            Weapon knife = new Weapon("Knife", 10, 25, false);

            bool win = false;
            bool exit = false;
            bool intro = false;
            int survive = 0;

            Weapon[] weapons =
            {
                machete, pistol, machineGun, sharpaxe, sword, shotgun, knife,
            };
            Weapon weapon1 = weapons[new Random().Next(weapons.Length)];

            Player player1 = new Player(yourName, player, weapon1, 100, 20, 100, 45, 150);
            Zombie Rona = new Zombie("zombie", 75, 0, 50, 100, "bloody walking dead", 15, 60);

            Zombie[] zombies = { Rona, Rona, Rona };

            Zombie zombie = zombies[new Random().Next(zombies.Length)];

            do
            {


                Console.WriteLine(
                    "a) check out the noise\n" +
                    "b) go back inside\n" +
                    "c) go the opposite direction of the noise\n" +
                    "d) look around");

                ConsoleKey choice = Console.ReadKey(true).Key;

                switch (choice)
                {
                    case ConsoleKey.A:
                        survive++;
                        Console.Clear();
                        Console.WriteLine("What are you? The first actress shown in a horror movie?");
                        System.Threading.Thread.Sleep(3800);
                        Console.WriteLine("Well look at that!");
                        System.Threading.Thread.Sleep(1700);
                        Console.WriteLine("on your way to checking the noise out you find a " + weapon1.ToString() + ", lying on the ground");
                        intro = true;
                        break;

                    case ConsoleKey.B:
                        survive++;
                        Console.Clear();
                        Console.WriteLine("Probably the best choice!");
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");

                        Console.WriteLine("You forgot your keys and the door automatically locked behind you, Now what?");
                        break;

                    case ConsoleKey.C:
                        survive++;
                        Console.Clear();
                        Console.WriteLine("You have chosen");
                        System.Threading.Thread.Sleep(1000);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        System.Threading.Thread.Sleep(250);
                        Console.Write(".");
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.Write("po");
                        System.Threading.Thread.Sleep(250);
                        Console.Write("oo");
                        System.Threading.Thread.Sleep(250);
                        Console.WriteLine("rly");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("In a rush to runaway you slip and fall into a manhole");
                        System.Threading.Thread.Sleep(1500);
                        Console.WriteLine("A broken ladder step jabs you right in the throat.");
                        player1.Life = 0;
                        exit = true;
                        break;

                    case ConsoleKey.D:
                        survive++;
                        Console.Clear();
                        weapon1 = weapons[new Random().Next(weapons.Length)];
                        Console.WriteLine("There is a " + weapon1.ToString() + " lying on the ground");
                        intro = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("that was not a valid answer. Please try again");
                        break;

                }

                if (intro)
                {
                    Console.WriteLine("pick it up? Y/N ");
                    ConsoleKey pickUp = Console.ReadKey(true).Key;
                    Console.Clear();

                    switch (pickUp)
                    {
                        case ConsoleKey.Y:
                            survive++;
                            Console.WriteLine("You picked up the {0}", weapon1);
                            exit = true;
                            break;

                        case ConsoleKey.N:
                            survive++;
                            Console.WriteLine("Soooo you are just gonna leave that there?");
                            exit = false;
                            intro = false;
                            break;
                    }

                }
            } while (!exit);

            if (player1.Life > 0)
            {
                Console.WriteLine("A dark figure is walking towards you. As it approaches and becomes into view it appears to be person injured limping." +
                    "\nHow do you react?\n" +
                    "a) yell, Hey! what is going on?\n" +
                    "b) run away?\n" +
                    "c) use what you just picked up.");

                ConsoleKey ask = Console.ReadKey(true).Key;

                switch (ask)
                {
                    case ConsoleKey.A:
                        survive++;
                        Console.WriteLine("The figure picks up speed and lunges at you.");
                        Combat.SaveYourself(zombie, player1);
                        Console.WriteLine("After being attacked, there is a scruffle.");
                        System.Threading.Thread.Sleep(2500);
                        while(player1.Life > 0 && Rona.Life > 0)
                        {
                            Combat.DoCombat(player1, Rona);
                        }                        
                        break;
                    case ConsoleKey.B:
                        survive++;                        
                        if(player1.Occupation == PlayerClass.PoliceOfficer)
                        {
                            Console.WriteLine("As you run you hear footsteps behind you getting louder, and quickier the figure is catching up to you, catches you and takes you to the ground. and a fight to the death begins.");
                            Combat.SaveYourself(zombie, player1);
                            System.Threading.Thread.Sleep(1500);
                            Combat.DoCombat(zombie, player1);
                            while (player1.Life > 0 && Rona.Life > 0)
                            {
                                Combat.DoCombat(player1, Rona);
                            }
                        }
                        else if(player1.Occupation == PlayerClass.Engineer)
                        {
                            Console.WriteLine("Good thing you have been working on your cardio, you run for miles until those things are out of sight and find a group of people that have set up a shelter to be safe. You are now safe");
                            win = true;
                        }
                        else
                        {
                            Console.WriteLine("As you run you hear footsteps behind you getting louder, and quickier the figure is catching up to you, catches you and takes you to the ground. and a fight to the death begins.");
                            while (player1.Life > 0 && Rona.Life > 0)
                            {
                                Combat.DoCombat(player1, Rona);
                            }
                        }

                        break;
                    case ConsoleKey.C:
                        survive++;
                        Console.WriteLine("Good choice, Don't trust anybody, or anything!");

                        if (weapon1.IsRanged)
                        {
                            Combat.SaveYourself(player1, zombie);
                            Console.WriteLine("zombie life: " + zombie.Life + "\n" + yourName + " life: " + player1.Life);
                        }
                        if (player1.Occupation == PlayerClass.PoliceOfficer)
                        {
                            Combat.SaveYourself(zombie, player1);
                        }
                        while (zombie.Life > 0 && player1.Life > 0)
                        {
                            Combat.DoCombat(player1, zombie);
                            Console.WriteLine("zombie life: " + zombie.Life + "\n" + yourName + " life: " + player1.Life);
                        }
                        break;
                    default:
                        Console.WriteLine("make a decision");
                        break;

                }
            } 
            if(Rona.Life < 0)
            {
                Console.WriteLine("You have killed the zombie like creature.");
                System.Threading.Thread.Sleep(1800);
            }
                Rona.Life = 50;

            if (player1.Life > 0 && win == false)
            {
                Console.WriteLine("You drew the attention of others as you put down your first undead.\n what do you do?" +
                    "\na) run away?" +
                    "\nb) fight");

                ConsoleKey fightFlight = Console.ReadKey(true).Key;

                switch (fightFlight)
                {
                    case ConsoleKey.A:
                        survive++;
                        if (player1.Occupation == PlayerClass.Military)
                        {
                            Console.WriteLine("You think you got away right when you realize you took an alley that was a deadend, and now you have no choice but to fight");
                            Combat.DoCombat(player1, Rona);
                        }
                        else if (player1.Occupation == PlayerClass.Engineer)
                        {
                            Console.WriteLine("Good thing you have been working on your cardio, you run for miles until those things are out of sight and find a group of people that have set up a shelter to be safe. You are now safe");
                            win = true;
                        }
                        else
                        {
                            Console.WriteLine("They are too fast, they catch you");
                            Combat.SaveYourself(zombie, player1);
                        }

                        break;

                    case ConsoleKey.B:
                        survive++;
                        if (weapon1.IsRanged)
                        {
                            Combat.SaveYourself(player1, zombie);
                        }
                        while (player1.Life > 0 && zombie.Life > 0)
                        {
                            Combat.DoCombat(player1, zombie);
                            Console.WriteLine("\nzombie life: " + zombie.Life + "\n" + yourName + " life: " + player1.Life);
                        }
                        break;
                    default:
                        Console.WriteLine("good choice, a lack of one... just lay there and let them eat you");
                        Combat.SaveYourself(zombie, player1);
                        break;
                }
            }
            if (player1.Life > 0 && win == false)
            {
                Console.WriteLine("They just keep coming! fight them off!");

                while (player1.Life > 0)
                {
                    Rona.Life = 50;

                    Console.WriteLine("a) fight \nb) give up");

                    ConsoleKey endGame = Console.ReadKey(true).Key;

                    switch (endGame)
                    {
                        case ConsoleKey.A:
                            while (player1.Life > 0 && Rona.Life > 0)
                            {
                                Combat.DoCombat(player1, Rona);
                            }                            
                            break;
                        case ConsoleKey.B:
                            player1.Life = 0;
                            Console.WriteLine("Such a shame there is no fight in you.");
                            break;
                        default:
                            player1.Life = 0;
                            Console.WriteLine("You have given up and let the zombies eat you.");
                            break;
                    }
                }
            }

            if (win)
            {
                Console.WriteLine("You have survived the reanimation. \nCONGRATULATIONS!!!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("YOU");
                System.Threading.Thread.Sleep(1800);
                Console.WriteLine("ARE");
                System.Threading.Thread.Sleep(1800);
                Console.WriteLine("DEAD!!!");
                System.Threading.Thread.Sleep(1800);

                Console.WriteLine("You're survival rate is " + survive);
            }



        }//end of main

        //static T RandomEnumValue<T>()
        //{
        //    var v = Enum.GetValues(typeof(T));
        //    return (T)v.GetValue(new Random().Next(v.Length));
        //}

    }//end of class
}
