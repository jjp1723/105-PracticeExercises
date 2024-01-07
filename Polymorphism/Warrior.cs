using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Warrior : Character
    {
        //Parameters
        private int daySinceBath;

        //Parameterized constructor
        public Warrior(int attribute, string name, int stength, int dexterity, int intelligence) : base(name, stength, dexterity, intelligence)
        {
            daySinceBath = attribute;
        }

        //Get and set property for daySinceBath
        public int Bath
        {
            get
            {
                return daySinceBath;
            }

            set
            {
                daySinceBath = value;
            }
        }

        //Special Move method
        public override void SpecialMove()
        {
            base.SpecialMove();

            //If the warrior hasn't bathed in more than 2 days, he will not make new friends, but will if he has bathed in 2 days
            if (daySinceBath > 2)
            {
                Console.WriteLine(" an attempt to make friends.  The odor is unbearable!  No new friends have been found.\n");
            }
            else
            {
                Console.WriteLine(" an attempt to make friends.  New friends have been found!\n");
            }
        }

        //TakeBath method to change daySinceBath attribute to 0
        public void TakeBath()
        {
            Console.WriteLine(name + " took a bath for the first time in " + daySinceBath + " day(s).\n");
            daySinceBath = 0;
        }

        //PrintWarrior method
        public override string ToString()
        {
            return base.ToString() + ("  " + name + " is a warrior.\n" + name + " hasn't bathed in " + daySinceBath + " day(s).\n");
        }
    }
}
