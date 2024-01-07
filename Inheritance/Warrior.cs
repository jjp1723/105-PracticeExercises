using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
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
        public void SpecialMove()
        {
            Console.Write(name + " attempts to make friends.  ");

            //If the warrior hasn't bathed in more than 2 days, he will not make new friends, but will if he has bathed in 2 days
            if(daySinceBath > 2)
            {
                Console.WriteLine("The odor is unbrearable!  No new friends have been found.\n");
            }
            else
            {
                Console.WriteLine("New friends have been found!\n");
            }
        }

        //PrintWarrior method
        public void PrintWarrior()
        {
            this.Print();
            Console.WriteLine(name + " is a warrior.\n" + name + " hasn't bathed in " + daySinceBath + " day(s).\n");
        }
    }
}
