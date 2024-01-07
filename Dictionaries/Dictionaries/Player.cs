using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Player
    {
        //Fields
        protected string name;
        protected int score;



        //Field Properties
        //Name Property
        public string Name
        {
            get
            {
                return name;
            }
        }

        //Score Property
        public int Score
        {
            get
            {
                return score;
            }
        }



        //Parameterized Constructor
        public Player(string id, int pts)
        {
            name = id;
            score = pts;
        }



        //Overriding ToString
        public override string ToString()
        {
            return ("Name: " + name + "\tScore: " + score);
        }
    }
}
