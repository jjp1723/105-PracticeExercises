using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Enums
{
    class Dragon : Monster
    {
        //Parameterized constructor
        public Dragon(int hp, Damage tp, string id, Random rnj) : base(hp, tp, id, rnj)
        {
        }

        //Attack method
        public override int Attack()
        {
            int dmg = (int)rng.Next(11) + 10;
            return dmg;
        }

        //Overriding ToString method
        public override string ToString()
        {
            return "The dragon " + base.ToString();
        }
    }
}
