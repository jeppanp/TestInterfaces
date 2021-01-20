using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;
using Labb3VG.MyMonster.Water;

namespace Labb3VG
{
    static class Utility
    {
        static Random random = new Random();
        static int nr;
        
        public static int AttackNames()
        {
            return random.Next(3);
        }
        public static int MonsterNames()
        {
            
            return random.Next(6);
        }

        public static int RandomLvl()
        {
            
            return random.Next(1, 11);
        }

        public static int Number1To10()
        {
            nr = random.Next(1, 11);

            return nr;
        }

        public static int AttackOrMiss()     // 10 procent to miss the attack for monsters
        {
            
            if (Number1To10() != 1)
            {
                nr = 1;
            }
            else
            {
                nr = 2;
            }
            return nr;
        }

        public static int StrenghtInAttack(int strengtMonster)
        {
            nr = random.Next(1, 3);

            if (strengtMonster>5)
            {
                nr = random.Next(1, 7);
            }
            
            return nr + strengtMonster;
        }

    }
}
