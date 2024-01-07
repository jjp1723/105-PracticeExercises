using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
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
        public void SpecialMove()
        {
            //The thief will get a new provider if he gets more than 5 spam calls, but will keep their current one if they don't
            if (cellphone > 5)
            {
                Console.WriteLine(name + " is fed up with his cell phone ruining his carefully laid sneak attacks,\nand finally changes to a new cell phone provider in the hopes of blocking spam calls.\n");
            }
            else
            {
                Console.WriteLine(name + " browses for new cell phone providers, but ultimately decides his current plan is fine.\n");
            }
        }

        //PrintWarrior method
        public void PrintThief()
        {
            this.Print();
            Console.WriteLine(name + " is a thief.\n" + name + "'s cell phone inappropriately rings " + cellphone + " times per day.\n");
        }
    }
}
