using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_File_IO
{
    class Player
    {
        //Fields
        protected string name;
        protected int attack;
        protected double weight;



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
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }



        //Parameterized Constructor
        public Player(string id)
        {
            name = id;

            Random rng = new Random();
            attack = rng.Next(26);
            weight = rng.Next(201);
        }



        //Overriding ToString Method
        public override string ToString()
        {
            return ("Player's name: " + name + ", Player's attack: " + attack + ", player's weight: " + weight + "lbs.");
        }
    }
}
