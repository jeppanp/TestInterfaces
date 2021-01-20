using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using Labb3VG.MyMonster;

namespace Labb3VG
{
    interface IMonster
    {
        public string Name { get; }
        public int HP { get; set; }
        public int DropGold { get; }
        public int Experience { get; }
        public int Lvl { get; }
        public string Race { get; }
        public string Sound { get; }
        public string Element { get; }
        public int Damage { get; }
        public bool Dead { get; set; }


        public List<string> AttackNames { get; }


        public int Attack(bool defAmulet);



    }


}
