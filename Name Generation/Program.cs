using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating name generator
            Random rnjesus = new Random();
            NameGenerator nameGen = new NameGenerator(rnjesus);

            //Using the generator 10 times
            for(int i = 0; i < 10; i++)
            {
                string randName = nameGen.GenerateName();
                Console.WriteLine(randName);
            }

            //Printing statistics
            Console.WriteLine("\n");
            nameGen.PrintStatistics();



            //Keeps Window Open
            Console.ReadLine();
        }
    }
}
