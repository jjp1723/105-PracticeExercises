using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    class Die
    {
        //RolledATwenty Event
        public event MessageDelegate RolledATwenty;



        //Fields
        protected int rollcount;
        protected Random rng;



        //Default Constructor
        public Die()
        {
            rollcount = 0;
            rng = new Random();
        }



        //Methods
        //RollDie Method
        public int RollDie()
        {
            int diceroll = (int)rng.Next(21);
            rollcount++;

            if(diceroll == 20 && RolledATwenty != null)
            {
                RolledATwenty("Rolled a 20", ("This roll was number " + rollcount));
            }

            return diceroll;
        }
    }
}
