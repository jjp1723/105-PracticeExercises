using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an array of integers
            int[] numbers = new int[4];
            numbers[0] = 999;
            numbers[1] = 8763;
            numbers[2] = 12345678;
            numbers[3] = 2;

            Console.WriteLine("Length of array: " + numbers.Length);

            //Write an array search
            bool found = false;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] == 2)
                {
                    Console.WriteLine("Found a 2!");
                    found = true;
                }
            }

            if(!found)
            {
                Console.WriteLine("Did not find a 2...");
            }

            //Testing foreach loops
            Console.WriteLine("\n--- Testing FOREACH ---\n");

            //Loop through the same array as above
            foreach(var x in numbers)
            {

            }



            //Keeps window open
            Console.ReadLine();
        }
    }
}
