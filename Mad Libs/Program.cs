using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mad_Libs
{
    class Program
    {
        static void Main(string[] args)
        {
            //This mad lib uses Story One
            
            //Declaring variables
            String adjOne;
            String foodOne;
            String appliance;
            int number;
            String meltFood;
            String adjTwo;
            String adjThree;
            String adjFour;
            String verbOne;
            String foodTwo;
            String adverb;
            String foodThree;
            String tool;
            String verbTwo;
            String adjFive;
            String foodFour;
            
            //Asking User for their name
            Console.WriteLine("Hello, welcome to my mad lib!\n\nWhat is your name?\n");
            String userName = Console.ReadLine();

            //Getting input from the user for the mad lib
            Console.WriteLine("Enter an adjective");
            adjOne = Console.ReadLine();

            Console.WriteLine("Enter a food");
            foodOne = Console.ReadLine();

            Console.WriteLine("Enter the name of a kitchen appliance");
            appliance = Console.ReadLine();

            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the name of a food that melts");
            meltFood = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            adjTwo= Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            adjThree = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            adjFour = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            verbOne = Console.ReadLine();

            Console.WriteLine("Enter a food");
            foodTwo = Console.ReadLine();

            Console.WriteLine("Enter an adverb ending in -ly");
            adverb = Console.ReadLine();

            Console.WriteLine("Enter a food");
            foodThree = Console.ReadLine();

            Console.WriteLine("Enter the name of a kitchen tool");
            tool = Console.ReadLine();

            Console.WriteLine("Enter a verb");
            verbTwo = Console.ReadLine();

            Console.WriteLine("Enter an adjective");
            adjFive = Console.ReadLine();

            Console.WriteLine("Enter a food");
            foodFour = Console.ReadLine();


            //The program prints the mad lib

            Console.WriteLine("\n\nHere is a " + adjOne + " recipe for an Upside-Down " + foodOne + ":\n");
            Console.WriteLine("First, you preheat your " + appliance + " to " + number + " degrees.");
            Console.WriteLine("Next, melt a stick of " + meltFood + " in a ten-inch " + adjTwo + " skillet over a very " + adjThree + " flame.");
            Console.WriteLine("In a " + adjFour + " bowl " + verbOne + " granulated " + foodTwo + " and flour, stirring the mixture " + adverb + ".");
            Console.WriteLine("Add milk and " + foodThree + " and beat rapidly with an electric " + tool + ".");
            Console.WriteLine("Bake until your " + foodOne + " is ready.");
            Console.WriteLine("After the cake cools, " + verbTwo + " it from the " + appliance + " and turn it upside-down.");
            Console.WriteLine("Serve the " + foodOne + " warm with " + adjFive + " cream or small spoonfuls of " + foodFour + " on top.");



            //Keeps window open
            Console.ReadLine();
        }
    }
}
