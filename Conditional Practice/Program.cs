using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Changing colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            
            //Testing new conditionals
            int x = 10;
            int y = -2;
            bool doesThisWork = false;

            if(x > 0 || doesThisWork)
            {
                Console.WriteLine("Hooray");
            }

            else if(x < 0)
            {
                Console.WriteLine("Less");
            }

            else
            {
                Console.WriteLine("NONE");
            }

            if(x == 5)
            {
                Console.WriteLine("Stuff");
            }




            switch(x)
            {
                case 0:
                case 1:
                    Console.WriteLine("Zero or one");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 10:
                    Console.WriteLine("Ten");
                    break;
            }



            for(int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }

                Console.WriteLine("Value of i: " + i);
            }



            //Keeps program running
            Console.ReadLine();
        }
    }
}
