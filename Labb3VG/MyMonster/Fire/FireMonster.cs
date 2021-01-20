//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labb3VG.MyMonster.Fire
//{
//    class FireMonster : Monster
//    {

//        public override int Attack(Player player)
//        {
//            int attack = 0;
//            int reduceDamage = 0;
//            if (player.DefAmulet)
//            {
//                reduceDamage = -2;
//            }

//            int nr = random.Next(1, 11);                     // random 10% to create a miss. 
//            if (nr != 1) 
//            {
//                nr = random.Next(1, 4);                      // otherwise 33% of which hit the monster gets in. 
//            }
//            else
//            { 
//                nr = 4;
//            }

//            switch (nr)
//            {
//                case 1:
                    
//                    attack = Strength + 1 + reduceDamage;
//                    Console.WriteLine($"{Name} hits you with a fireflame, dealing {attack} damage.");
//                    break;

//                case 2:
//                    attack = Strength + 2 + reduceDamage;
//                    Console.WriteLine($"{Name} hits you with a great fire ball , dealing {attack} damage.");
//                    break;

//                case 3:
//                    attack = Strength + 5 + reduceDamage;
//                    Console.WriteLine($"aaaoouuch. The {Name} hits you with a wall of fire, dealing {attack} damage.");
//                    break;

//                case 4:
//                    Console.WriteLine("Nice maneuver! You managed to avoid the burning fire!");
//                    attack = 0;
//                    break;
//            }

//            return attack;
//        }
//    }
//}
