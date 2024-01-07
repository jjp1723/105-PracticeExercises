using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investigating_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wrong way
            Console.WriteLine("Incorrecctly generated results:\n");

            int[] badNumbers = new int[10];

            //Loop with random object inside
            for(int i = 0; i < 300; i++)
            {
                Random badRNG = new Random();

                int randNumBad = badRNG.Next(10);

                badNumbers[randNumBad]++;
            }

            //Printing incorrect results
            Console.WriteLine("0: " + badNumbers[0] + "\n1: " + badNumbers[1] + "\n2: " + badNumbers[2] + "\n3: " + badNumbers[3] + "\n4: " + badNumbers[4] + "\n5: " + badNumbers[5] + "\n6: " + badNumbers[6] + "\n7: " + badNumbers[7] + "\n8: " + badNumbers[8] + "\n9: " + badNumbers[9]);



            //Right way
            Console.WriteLine("\n\n\nCorrectly generated results:\n");

            int[] goodNumbers = new int[10];

            //Loop with the random object outside
            Random goodRNG = new Random();

            for(int j = 0; j < 300; j++)
            {
                int randNumGood = goodRNG.Next(10);

                goodNumbers[randNumGood]++;
            }

            //Determining the maximum and minimum occurences of all integers
            int max = goodNumbers.Max();
            int min = goodNumbers.Min();

            //Printing correct results with color coding
            for(int k = 0; k < 10; k++)
            {
                //Color coding for maximum
                if (goodNumbers[k] == max)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                //Color coding for minimum
                else if(goodNumbers[k] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                //Color coding for everything else
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(k + ": " + goodNumbers[k]);
            }




            //Keeps Window Open
            Console.ReadLine();
        }
    }
}
