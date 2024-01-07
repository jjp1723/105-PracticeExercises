using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZIP_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output for testing - this is a comment (duh)
            Console.WriteLine("Basic console output");

            //Draw a circle in the console

            //Our loop goes from 0 to 2 pi, representing angles around a circle
            for(double angle = 0; angle < Math.PI * 2; angle += 0.1)
            {
                //Adjusting the position of the X around the console to create a circle
                Console.CursorLeft = (int)(Math.Cos(angle) * 10) + 12;
                Console.CursorTop = (int)(Math.Sin(angle) * 10) + 12;
                Console.Write("X");
            }

            //Variable declaration examples

            int x = 10;

            Int32 y = 10;

            uint unsignedX = (uint)x;
            Console.WriteLine("Unsighned x value: " + unsignedX);

            //Keep the window open
            Console.ReadLine();
        }
    }
}
