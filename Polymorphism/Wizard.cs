using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Wizard : Character
    {
        //Parameters
        private int hotPocket;
        private Random rng;

        //Parameterized constructor which takes a Random to be used in SpecialMove
        public Wizard(int attribute, Random rngesus, string name, int stength, int dexterity, int intelligence) : base(name, stength, dexterity, intelligence)
        {
            hotPocket = attribute;
            rng = rngesus;
        }

        //Get and set property for daySinceBath
        public int HotPocket
        {
            get
            {
                return hotPocket;
            }

            set
            {
                hotPocket = value;
            }
        }

        //Special Move method
        public override void SpecialMove()
        {
            base.SpecialMove();

            //Generating a random number; to determine whether the wizard will create a hot pocket
            int number = rng.Next(101);

            //If the number is lower than the percent chance of creating a hot pocket, then a hot pocket is created; otherwise, the spell is performed successfully
            if (number < hotPocket)
            {
                Console.WriteLine(" a spell.  Instead, a Hot Pocket (tm) falls to the ground with a thud.\n");
            }
            else
            {
                Console.WriteLine(" a spell.  The spell succeeds!\n");
            }
        }

        //EatPocket method to decrease hotPocket attribute by 10
        public void EatPocket()
        {
            if(hotPocket > 10)
            {
                hotPocket -= 10;
                Console.WriteLine(name + " ate a Hot Pocket (tm) to satisfy his craving.  " + name + " now creates Hot Pockets (tm) " + hotPocket + "% of the time.\n");
            }
        }

        //PrintWarrior method
        public override string ToString()
        {
            return base.ToString() + ("  " + name + " is a wizard.\n" + name + " creates Hot Pockets (tm) " + hotPocket + "% of the time.\n");
        }
    }
}
