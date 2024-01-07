using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get some user input
            Console.Write("Please enter your age: ");
            String userAge = Console.ReadLine();

            //Attempt to parse, checking for success
            //Need a variable to hold results
            int value = 0;

            if (int.TryParse(userAge, out value) == true)
            {
                int age = int.Parse(userAge);

                int days = age * 365;
                Console.WriteLine("\nThat is " + days + " days!");
            }
            else
            {
                Console.WriteLine("\nUser Error\n\nRecommend Execution");
            }

            Console.ReadLine();
        }
    }
}
