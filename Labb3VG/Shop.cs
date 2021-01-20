﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labb3VG
{
    static class Shop
    {

        private static bool userAnswerInBool;
        private static int userAnswer;
        private static bool keepGoing;





        public static void ShopMenu(Player player)
        {
            keepGoing = true;


                Console.WriteLine($"Welcome {player.Name} to AbuHassans Shop \nWhat would you like to buy?");
                while (keepGoing)
            {
                Console.WriteLine($"You have {player.Gold} gold to spend.\n******");
                Console.WriteLine("1. Attack Amulet (+  5 strengt) - 150 gold");
                Console.WriteLine("2. Defense Amulet (+ 2 toughness)- 150 gold");
                Console.WriteLine("3. Fire Sword ( + 8 power against Grass monster) - 100 gold");    // Alla ändringar här görs i playerklassen. Ex player.strengt + 5. Sen ändra jag i attack med vapen
                Console.WriteLine("4. Electric Rod ( + 8 power against Water monster) - 100 gold");
                Console.WriteLine("5. Trident (+ 8 power against Fire monster) - 100 gold ");
                Console.WriteLine("6. Healt Potions ( + 100 hp) - 20 gold");
                Console.WriteLine("7. Go back to menu");

                userAnswerInBool = Int32.TryParse(Console.ReadLine(), out userAnswer);

                switch (userAnswer)
                {
                    case 1:
                        if (player.Gold >= 100 && player.AtkAmulet == false)
                        {
                            Console.WriteLine("You bought an amulet. You can feel its power.");
                            player.Strength += 5;
                            player.AtkAmulet = true;
                            player.Gold -= 150;

                        }
                        else if (player.AtkAmulet)
                        {
                            Console.WriteLine("Your idiot, wasting money on something you already got. Suit your self consumption freak ");
                            player.Gold -= 150;
                        }
                        else
                        {
                            Hustle();

                        }
                        break;

                    case 2:
                        if (player.Gold >= 150 && player.DefAmulet == false)
                        {
                            Console.WriteLine("You bought an amulet. You can feel its power.");
                            player.Toughness += 2;
                            player.DefAmulet = true;
                            player.Gold -= 150;

                        }

                        else if (player.AtkAmulet)
                        {
                            Console.WriteLine("Your idiot, wasting money on something you already got. Suit your self consumption freak ");
                            player.Gold -= 150;
                        }
                        else
                        {
                            Hustle();

                        }
                        break;
                    case 3:
                        if (player.Gold >= 100)
                        {
                            Console.WriteLine("You bought a Fire Sword. You can hear its sound \"FCCSHHHH\" while you swing it through the air.");
                            player.FireWeapon = true;
                            player.Gold -= 100;

                        }
                        else
                        {
                            Hustle();

                        }
                        break;
                    case 4:
                        if (player.Gold >= 100)
                        {
                            Console.WriteLine("You bought an Electric Rod. The flashes surronds it and fire lightnings");
                            player.GrassWeapon = true;
                            player.Gold -= 100;

                        }
                        else
                        {
                            Hustle();

                        }
                        break;
                    case 5:
                        if (player.Gold >= 100)
                        {
                            Console.WriteLine("You bought a Trident. You are now the king of the ocean!");
                            player.WaterWeapon = true;
                            player.Gold -= 100;

                        }
                        else
                        {
                            Hustle();

                        }
                        break;
                    case 6:
                        if (player.Gold >= 50 && player.HpCurrently > 0)        
                        {
                            Console.WriteLine("You bought a Healt Potion. \"slurp\", \"slurp\",\"slurp\" aaaah, feeling much better already");
                            player.HpCurrently += 100;
                            if(player.HpCurrently > player.HpBar)
                            { player.HpCurrently = player.HpBar;
                                Console.WriteLine("Easy tiger, why did you drink so much? Such a waste. Your hp is maximum");
                            }
                            player.Gold -= 50; 

                        }
                        else if(player.HpCurrently <= 0)
                        {
                            Console.WriteLine("AbuHassan gets a strange feeling and the curtains flutter. It must be a visit from the dead");
                            keepGoing = false;
                        }
                        else
                        {
                            Hustle();

                        }
                        break;

                    case 7:
                        keepGoing = false;
                        break;



                }
            }
        }

        private static void Hustle()
        {
            Console.WriteLine("Hey man, are you trying to hustle me? Get out of my shop!");
            keepGoing = false;

        }


    }
}
