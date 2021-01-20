using System;
using System.Collections.Generic;
using System.Threading;
using Labb3VG.MyMonster;
//using Labb3VG.MyMonster.Fire;
//using Labb3VG.MyMonster.Grass;
using Labb3VG.MyMonster.Water;
using Microsoft.VisualBasic;
namespace Labb3VG
{
    static class GameLogic
    {
        static List<Monster> monsterList = new List<Monster>();
        static Player player = new Player();
        static Random rnd = new Random();
        static bool keepGoing = true;
        static int userAnswer;
        static bool userAnswerInBool;
        static int damage;
        static Monster monster;
        

        public static void Start()
        {
            Console.Clear();
            Console.Title = "Save Hisingen";
            CreateMonsters();

            Console.WriteLine("**********************");
            Console.WriteLine("*Welcome to the Game!*");
            Console.WriteLine("**********************");
            Console.Write("Enter your namne: ");
            player.Name = Console.ReadLine();
        
            Menu();
        }

        private static void Menu()
        {
            while (keepGoing)
            {


                Console.WriteLine("1. Go adventuring");
                Console.WriteLine("2. Show details about your character");
                Console.WriteLine("3. Shop");
                Console.WriteLine("4. Exit Game");
                Console.Write(">");
                userAnswerInBool = Int32.TryParse(Console.ReadLine(), out userAnswer);

                switch (userAnswer)
                {

                    case 1:
                        Battle();
                        //GoAdventuring();
                        break;

                    case 2:
                        PlayerDetails();
                        break;

                    case 3:
                        Shop.ShopMenu(player);
                        break;

                    case 4:
                        keepGoing = false;
                        break;

                }

            }
        }

        private static void Battle()
        {
            monster = monsterList[Utility.Number1To10()];  // Slumpa fram lvlbaserat
            monster.Greetings();

            while(!player.Dead && !monster.Dead)
                {

            damage = player.Attack(monster);
            monster.TakeDamage(damage);
                if (monster.HP <= 0)
                {
                    monster.Dead = true;
                    MonsterIsDead(monster);
                    
                }
                else
                {
                    damage = monster.Attack(player.DefAmulet);
                    player.TakeDamage(damage);

                    player.BattleStatus();
                    monster.BattleStatus();
                }


            }




        }

        private static void MonsterIsDead(Monster monster)
        {
            Console.WriteLine($"And with that strike you killed the monster! Gaining {monster.Experience} experience and looted {monster.DropGold} gold");

            player.Gold += monster.DropGold;
            player.Experience += monster.Experience;

            if (player.Experience >= player.LvlBar)
            {
                player.LvlUp();
            }

            Console.WriteLine("[Press enter to go back to menu]");
            Console.ReadKey();
            
        }



        //private static void GoAdventuring()
        //{
        //    if (IsPlayerAlive())
        //    {
        //        int adventure = rnd.Next(1, 101);
        //        if (adventure > 10 && adventure < 96)
        //        {

        //            switch (rnd.Next(1, 4))        // slumpar fram vilken typ av monster. gräs, eld eller vatten
        //            {
        //                case 1:

        //                    Fight(monsterToFight);
        //                    break;
        //                case 2:

        //                    Fight(monsterToFight);
        //                    break;
        //                case 3:

        //                    Fight(monsterToFight);
        //                    break;
        //            }
        //        }
        //        else if (adventure > 95)
        //        {
        //            Console.WriteLine("wow, you find a hidden tressure. Looted 50 gold");
        //            player.Gold += 50;
        //        }
        //        else
        //        {
        //            Console.WriteLine("You see nothing but sawying grass all around you");
        //        }
        //    }
        //    else
        //    {
        //        Menu();
        //    }
        //}

        //private static void Fight(Monster monsterToFight)
        //{

        //    do
        //    {

        //        monsterToFight.HP -= player.Attack(monsterToFight, player);            //spelare attackerar först 
        //        if (monsterToFight.HP > 0)                         // om monster har hp så får den slå
        //        {

        //            player.HpCurrently -= monsterToFight.Attack(player);
        //        }
        //        else if (monsterToFight.HP <= 0)                   // om den inte har hp, innebär de att spelaren dödade den och fighten är över. 
        //        {
        //            Console.WriteLine($"And with that strike you killed the monster! Gaining {monsterToFight.Experience} experience and looted {monsterToFight.DropGold} gold");

        //            player.Gold += monsterToFight.DropGold;
        //            player.Experience += monsterToFight.Experience;

        //            if (player.Experience >= player.LvlBar)
        //            {
        //                player.LvlUp();
        //            }

        //            Console.WriteLine("[Press enter to go back to menu]");
        //            Console.ReadKey();
        //            break;
        //        }
        //        if (player.HpCurrently <= 0)           // bestämm om de ska ske något när en dör. tappa guld? avbryta spelet? healing möjlighet? 
        //        {
        //            Console.WriteLine("You were killed by the monster :(");
        //            Console.WriteLine("[Press enter to go back to menu]");
        //            Console.ReadKey();
        //            break;
        //        }

        //        Console.WriteLine($"{player.Name}: {player.HpCurrently}");
        //        Console.WriteLine($"{monsterToFight.Name}: {monsterToFight.HP}");
        //        Console.WriteLine("[Press enter to continue]");
        //        Console.ReadKey();
        //    } while (monsterToFight.HP > 0 && player.HpCurrently > 0);
        //}

        private static bool IsPlayerAlive()
        {
            if (player.HpCurrently > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Sorry mate, you´re dead. Try to find a healer that can bring you back from the dead. But it will cost you...");
                Console.ReadKey();
                return false;
            }

        }

        //private static Monster DecideLVLMonster(List<Monster> monsters)
        //{
        //    if (player.Lvl <= 3)
        //    {
        //        monsterToFight = monsters.Find(x => x.Lvl <= 3);
        //        Console.WriteLine(monsterToFight.Greetings());
        //        monsters.Remove(monsterToFight);             // Removing the monster from the list, so I don´t fight the same monster all the time. 


        //    }
        //    else if (player.Lvl >= 4 && player.Lvl < 7)
        //    {
        //        monsterToFight = monsters.Find(x => x.Lvl <= 7);
        //        Console.WriteLine(monsterToFight.Greetings());
        //        monsters.Remove(monsterToFight);

        //    }
        //    else if (player.Lvl >= 7)
        //    {
        //        monsterToFight = monsters.Find(x => x.Lvl >= 6);
        //        Console.WriteLine(monsterToFight.Greetings());
        //        monsters.Remove(monsterToFight);

        //    }
        //    return monsterToFight;
        //}

        private static void PlayerDetails()
        {
            Console.WriteLine(player);
            Console.WriteLine("[Press enter to go back to menu]");
            Console.ReadKey();
            Console.Clear();
        }


        private static void CreateMonsters()   // Just because i want random kind of monsters, in different lvls i go through this loop. And the settings gives them random lvls and names. 
        {

            for (int i = 0; i < 15; i++)
            {
                //Dragon dragon = new Dragon();
                //fireMonsters.Add(dragon);

                //Demon demon = new Demon();
                //fireMonsters.Add(demon);

                //Tortoise tortoise = new Tortoise();
                //waterMonsters.Add(tortoise);

                //SwampTroll troll = new SwampTroll();
                //waterMonsters.Add(troll);

                monsterList.Add(new Crocodile());
                

                //RabiesBear bear = new RabiesBear();
                //grassMonsters.Add(bear);

                //Wasp wasp = new Wasp();
                //grassMonsters.Add(wasp);

                //Scarab scarab = new Scarab();
                //grassMonsters.Add(scarab);
            }

            //DragonLord dL = new DragonLord();  // but only one dragon lord.
            //fireMonsters.Add(dL);



        }

    }
}
