using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating a new game
            Game guessingGame = new Game(new Random());

            guessingGame.PlayGame();



            //Keeps Window Open
            Console.ReadLine();
        }
    }
}
