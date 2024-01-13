using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_for_1
{
    public class Player
    {
        // class for player class
        //can add functionality down the road, not much use now except for readability
        public string name;
        public int hp;
        public int maxhp;
        public int dmg;
        public int range;

        public Player(string inname, int classint)
        {
            name = inname;
            switch (classint)
            {
                case 0:
                    hp = 30;
                    maxhp = 30;
                    dmg = 30;
                    range = 5;
                    break;
                case 1:
                    hp = 50;
                    maxhp = 50;
                    dmg = 20;
                    range = 10;
                    break;
                case 2:
                    hp = 20;
                    maxhp = 20;
                    dmg = 30;
                    range = 40;
                    break;

                default:
                    hp = 0;
                    break;
            }

        }
    }
}
