using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a random object for random number generation
            Random rng = new Random();

            /*
            for(int i = 0; i < 10; i++)
            {
                //Generate a random number
                int randNum = rng.Next();
                int randSmallRange = rng.Next(5, 10);
                double randDouble = rng.NextDouble();

                //Print to see what we get
                Console.WriteLine("Large range: " + randNum);
                Console.WriteLine("Small range: " + randSmallRange);
                Console.WriteLine("Double range: " + randDouble);
            }
            */

            //Testing lists
            List<int> numbers = new List<int>();

            numbers.Add(1234);
            numbers.Add(6);
            numbers.Add(7);
            numbers.Add(92);
            numbers.Add(4321);

            numbers.Remove(6);

            Console.WriteLine("Count: " + numbers.Count);
            Console.WriteLine("Capacity: " + numbers.Capacity);

            foreach(int j in numbers)
            {
                Console.WriteLine(j);
            }
            



            //Keep window open
            Console.ReadLine();
        }
    }
}
