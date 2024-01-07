using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
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

        //Overridable SpecialMove method
        public virtual void SpecialMove()
        {
            Console.Write(name + " performs...");
        }

        //ToString method
        public override string ToString()
        {
            return name + " has " + strength + " strength, " + dexterity + " dexterity, and " + intelligence + " intelligence.";
        }
    }
}
