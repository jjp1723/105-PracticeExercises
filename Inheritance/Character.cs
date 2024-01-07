using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Character
    {
        //Parameters
        protected string name;
        protected int strength;
        protected int dexterity;
        protected int intelligence;

        //Parameterized constructor
        public Character(string id, int power, int skill, int smart)
        {
            name = id;
            strength = power;
            dexterity = skill;
            intelligence = smart;
        }

        //Get and set properties

        //Name
        public string Name
        {
            get
            {
                return name;
            }
        }

        //Strength
        public int Strength
        {
            get
            {
                return strength;
            }

            set
            {
                strength = value;
            }
        }

        //Dexterity
        public int Dexterity
        {
            get
            {
                return dexterity;
            }

            set
            {
                dexterity = value;
            }
        }

        //Intelligence
        public int Intelligence
        {
            get
            {
                return intelligence;
            }

            set
            {
                intelligence = value;
            }
        }



        //Print method
        public void Print()
        {
            Console.WriteLine(name + " has " + strength + " strength, " + dexterity + " dexterity, and " + intelligence + " intelligence.");
        }
    }
}
