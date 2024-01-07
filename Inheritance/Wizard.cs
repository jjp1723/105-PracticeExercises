using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Wizard : Character
    {
        //Parameters
        private int hotPocket;

        //Parameterized constructor
        public Wizard(int attribute, string name, int stength, int dexterity, int intelligence) : base(name, stength, dexterity, intelligence)
        {
            hotPocket = attribute;
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
        public void SpecialMove()
        {
            Console.Write(name + " attempts to cast a spell.  ");

            //Generating a random number; to determine whether the wizard will create a hot pocket
            Random rng = new Random();
            int number = rng.Next(101);

            //If the number is lower than the percent chance of creating a hot pocket, then a hot pocket is created; otherwise, the spell is performed successfully
            if (number < hotPocket)
            {
                Console.WriteLine("Instead, a Hot Pocket (tm) falls to the ground with a thud.\n");
            }
            else
            {
                Console.WriteLine("The spell succeeds!\n");
            }
        }

        //PrintWarrior method
        public void PrintWizard()
        {
            this.Print();
            Console.WriteLine(name + " is a wizard.\n" + name + " creates Hot Pockets (tm) " + hotPocket + "% of the time.\n");
        }
    }
}
