//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Labb3VG.MyMonster.Grass
//{
//    class GrassMonster:Monster
//    {
//        private string specialAttack;
//        private string specialAttack2;
//        private string normalAttack;

//        public string SpecialAttack { get => specialAttack; set => specialAttack = value; }
//        public string NormalAttack { get => "Lice Attack"; set => normalAttack = value; }
//        public string SpecialAttack2 { get => specialAttack2; set => specialAttack2 = value; }

 
//        public override int Attack(Player player)
//        {
//            int attack = 0;
//            int reduceDamage = 0;
//            if (player.DefAmulet)
//            {
//                reduceDamage = -2;
//            }

//            switch (random.Next(1, 4))
//            {


//                case 1:
//                    attack = Strength + 1 + reduceDamage;
//                    Console.WriteLine($"{Name} hits you with a {NormalAttack} , dealing {attack} damage.");
//                    break;

//                case 2:
//                    attack = Strength + 2 + reduceDamage;
//                    Console.WriteLine($"{Name} hits you with a {SpecialAttack}, dealing {attack} damage.");
//                    break;

//                case 3:
//                    attack = Strength + 3 + reduceDamage;
//                    Console.WriteLine($"{Name} hits you with a {SpecialAttack2}, dealing {attack} damage.");
//                    break;
//            }

//            return attack;
//        }
//    }
//}
