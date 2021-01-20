using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Labb3VG.MyMonster.Water
{
    class Crocodile : Monster, IMonster
    {

        static List<string> crocNames = new List<string>() { "Crocks", "Allie", "Green Tail", "Lolong", "Steve Irwin", "Delta" };

        public Crocodile()
        {
            this.Name = crocNames[Utility.MonsterNames()];
            this.Element = "water";
            this.Race = "swamp troll";
            this.Sound = " He mumble for himself \"Hmmm, bugs\"";
            this.Lvl= Utility.RandomLvl();
            this.HP = 50 + (Lvl*4);
            this.DropGold = 15 + (Lvl * 3);  // Skriv en random drop? 
            this.Experience = 50 + (Lvl * 2);
            this.Damage = (int)Math.Round(Lvl * 1.5);
            this.AttackNames =  new List<string>() { "Tail Snapper", "Bite", "claw demolition" };


        }


        public override int Attack(bool defAmulet)
        {
            int attack = Utility.StrenghtInAttack(Damage);
                
            if (defAmulet)
            {
                attack -= 2;
            }

            if (Utility.AttackOrMiss() == 1)
            {
                
                Console.WriteLine($"{Name} hits you with a {AttackNames[Utility.AttackNames()]} dealing {attack} damage.");
            }
            else
            {
                Console.WriteLine($"Wow! That {AttackNames[Utility.AttackNames()]} just passed your head, didn´t get hurt.");
            }
           

            return attack;
        }


    }
}
