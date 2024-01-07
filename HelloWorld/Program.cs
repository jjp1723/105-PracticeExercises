using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints "Hello World"
            Console.WriteLine("Hello World");

            //Prints my name
            Console.WriteLine("John James Pionzio\n");

            //Cirle Areas
            Console.WriteLine("Cirle Areas:\n");

            //For loop
            for (int radius = 1; radius < 4; radius++)
            {
                double area = radius * radius * 3.14;
                Console.WriteLine("A Circle with radius " + radius + " has an area of " + area);
            }

            //Declaring new variable for while loop
            int radius2 = 4;

            //While loop
            while (radius2 < 7)
            {
                double area2 = radius2 * radius2 * 3.14;
                Console.WriteLine("A Circle with radius " + radius2 + " has an area of " + area2);
                radius2++;
            }

            //Declaring new variable for do-while loop
            int radius3 = 7;

            //Do-while loop
            do
            {
                double area3 = radius3 * radius3 * 3.14;
                Console.WriteLine("A Circle with radius " + radius3 + " has an area of " + area3);
                radius3++;
            } while (radius3 < 10);

            //For loop determining the product of all numbers between 1 and 9
            int number2 = 1;
            for(int number1 = 1; number1 < 10; number1++)
            {
                number2 = number2 * number1;
            }

            //If-Else Statement determining if the product of all numbers between 1 and 9 is even or odd
            int number3 = number2 % 1;
            
            if(number3 == 0)
            {
                Console.WriteLine("\nThe product of all numbers betwwn 1 and 9 is even\n");
            }
            else
            {
                Console.WriteLine("\nThe product of all numbers between 1 and 9 is odd\n");
            }

            //Switch Statement determining what part of the work week today is
            switch(DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("It is the Weekend");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("It is the first day of the work week");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("It is the last day of the work week");
                    break;
                default:
                    Console.WriteLine("It is the middle of work week");
                    break;
            }

            //Keeps program open
            Console.ReadLine();
        }
    }
}
