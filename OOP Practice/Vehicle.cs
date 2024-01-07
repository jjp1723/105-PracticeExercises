using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Vehicle
    {
        //Fields
        private string name;
        private string make;
        private double mileage;

        //Default Constructor
        public Vehicle()
        {
            name = "Honda";
            make = "Fit";
            mileage = 0;
        }

        //Parameterized Constructors
        public Vehicle(string brand, string model)
        {
            name = brand;
            make = model;
            mileage = 0;
        }

        public Vehicle(string brand, string model, double miles)
        {
            name = brand;
            make = model;
            mileage = miles;
        }

        //Method to increase mileage
        public void Drive(double distance)
        {
            mileage += distance;
        }

        //Print
        public void Print()
        {
            Console.WriteLine("Car FAX:");
            Console.WriteLine("Make: " + name);
            Console.WriteLine("Model: " + make);
            Console.WriteLine("Mileage: " + mileage);
        }
    }
}
