using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Guessing_Game
{
    class Game
    {
        //Fields
        private int number;
        private Random generator;
        private int guesses;

        //Instantiating an object
        public Game(Random rng)
        {
            generator = rng;
            number = 0;
            guesses = 0;
        }

        //PromptForGuess Method
        public int PromptForGuess()
        {
            int value = 0;

            //Creating a while loop to prevent the method from finishing until the ser inputs a valid guess
            bool valid = true;
            while(valid)
            {
                Console.WriteLine("Please guess a number between 0 and 100 (inclusive)");
                string guess = Console.ReadLine();

                //Making sure the user input a valid guess
                if(int.TryParse(guess, out value) == true)
                {
                    value = int.Parse(guess);

                    if((value < 101) && (value > -1))
                    {
                        valid = false;
                    }

                    //If the user guesses an integer that is not between 0 and 100
                    else
                    {
                        Console.Write("Sorry, you did not enter a number in the provided range.\t");
                    }
                }
                
                //If the user guesses a letter/word or a double
                else
                {
                    Console.Write("Sorry, your guess was not valid.\t");
                }
            }

            return value;
        }

        //IsGameOver method
        public bool IsGameOver(int currentGuess)
        {
            if(guesses < 8)
            {
                return true;
            }

            return false;
        }

        //PlayGame method
        public void PlayGame()
        {
            //Boolean value to keep the program wunning until the user no longer wants to play
            bool play = true;

            while (play)
            {
                generator = new Random();
                number = generator.Next(101);
                guesses = 0;

                while(IsGameOver(guesses))
                {
                    int currentGuess = PromptForGuess();
                    guesses++;

                    //If the user guesses correctly
                    if(currentGuess == number)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Correct!  You won in " + guesses + " turns.");
                        Console.ResetColor();
                        guesses = 8;
                    }

                    //If the user guesses too high
                    else if(currentGuess > number)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Too high");
                        Console.ResetColor();
                    }

                    //If the user guesses too low
                    else if (currentGuess < number)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Too Low");
                        Console.ResetColor();
                    }

                    if((guesses == 8) && (currentGuess != number))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Game Over: You ran out of turns.  The number was " + number);
                        Console.ResetColor();
                    }
                }

                //Prompting the user to play again
                Console.WriteLine("Would you like to play agan?  (Y/N)\n");
                string playMore = Console.ReadLine();

                if(playMore == "N")
                {
                    play = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
