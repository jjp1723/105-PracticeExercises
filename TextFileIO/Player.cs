using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextFileIO
{
    class Player
    {
        //Fields
        protected string name;
        protected int attack;
        protected int defense;



        //Field Propeteries
        //Name Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        //Attack Property
        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        //Defence Property
        public int Defense
        {
            get
            {
                return defense;
            }
            set
            {
                defense = value;
            }
        }



        //Parameterized Constructor
        public Player(string id)
        {
            name = id;

            Random rng = new Random();
            attack = rng.Next(26);
            defense = rng.Next(21);
        }



        //Overriding ToString Method
        public override string ToString()
        {
            return ("Player's name: " + name + ", Player's attack: " + attack + ", player's defense = " + defense);
        }
    }
}
