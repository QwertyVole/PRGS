using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_for_1
{
    public class Enemy
    {
        public string name;
        public int hp;
        public int dmg;
        public int range;
        public int distance;
        public Enemy(int strength, int indistsance, string inname)
        {
            hp = 10 * strength;
            dmg = 10 * strength;
            distance = indistsance;
            name = inname;


        }
    }
}
