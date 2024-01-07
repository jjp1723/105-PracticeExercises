using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Thief : Character
    {
        //Parameters
        private int cellphone;

        //Parameterized constructor
        public Thief(int attribute, string name, int stength, int dexterity, int intelligence) : base(name, stength, dexterity, intelligence)
        {
            cellphone = attribute;
        }

        //Get and set property for daySinceBath
        public int CellPhone
        {
            get
            {
                return cellphone;
            }

            set
            {
                cellphone = value;
            }
        }

        //Special Move method
        public override void SpecialMove()
        {
            base.SpecialMove();

            //The thief will get a new provider if he gets more than 5 spam calls, but will keep their current one if they don't
            if (cellphone > 5)
            {
                Console.WriteLine(" a search for new phone providers because " + name + " is fed up with his cell phone ruining his carefully\nlaid sneak attacks, and finally changes to a new cell phone provider in the hopes of blocking spam calls.\n");
            }
            else
            {
                Console.WriteLine(" a search for new cell phone providers, but ultimately decides his current plan is fine.\n");
            }
        }

        //CallBlock method to decrease callphone attribute by 1
        public void CallBlock()
        {
            if(cellphone > 0)
            {
                cellphone--;
                Console.WriteLine(name + " blocked a number.  " + name + "'s cell phone now inappropriately rings " + cellphone + " times per day.\n");
            }
        }

        //PrintWarrior method
        public override string ToString()
        {
            return base.ToString() + ("  " + name + " is a thief.\n" + name + "'s cell phone inappropriately rings " + cellphone + " times per day.\n");
        }
    }
}
