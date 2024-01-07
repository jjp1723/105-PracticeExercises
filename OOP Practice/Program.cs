using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate some vehicles
            Vehicle hisCar = new Vehicle();
            Vehicle myCar = new Vehicle("Ford", "Escape", 70000);

            //Using drive method
            hisCar.Drive(150);

            //Printing both
            hisCar.Print();
            myCar.Print();



            //Keeps Window Open
            Console.ReadLine();
        }
    }
}
