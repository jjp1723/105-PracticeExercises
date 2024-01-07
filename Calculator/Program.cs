using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a boolean variable to keep calculator running until quit
            bool play = true;

            //Loop which contains calculator functions
            while(play)
            {
                //Creating a variable to hold the user's selection within the calculator
                int select = 0;

                //Displays the choice menu for the user
                Console.WriteLine("\nChoose frome one of the following calculator choices by entering the corresponding number: ");
                Console.WriteLine("1 - Whole Number\t2 - Addition\t\t\t3 - Sine");
                Console.WriteLine("4 - Cosine\t\t5 - Absolute Value\t\t6 - Quit\n");

                //Testing to see if the user entered a number
                string input = Console.ReadLine();
                int value = 0;
                if(int.TryParse(input, out value) == true)
                {
                    select = int.Parse(input);
                }
                else
                {
                    Console.WriteLine("\nYou did not enter a number, try again\n");
                }

                switch(select)
                {
                    //Whole Number calculator code
                    case 1:

                        Console.WriteLine("\nYou chose Whole Number\nEnter a decimal value:");

                        //User enters decimal and program rounds it
                        String deciWord = Console.ReadLine();
                        double deci = double.Parse(deciWord);
                        int whole = (int)Math.Round(deci);

                        //Displaying the result
                        Console.WriteLine("\nThe whole number rounded from " + deci + " is: " + whole + "\n");
                        break;

                    //Addition calculator code
                    case 2:
                        
                        //User enters the first number
                        Console.WriteLine("\nYou chose Addition\nPlease enter the first number:");
                        String addWord1 = Console.ReadLine();
                        int addNum1 = int.Parse(addWord1);

                        //User enters the second number
                        Console.WriteLine("\nPlease enter the second number:");
                        String addWord2 = Console.ReadLine();
                        int addNum2 = int.Parse(addWord2);

                        //Adding the two numbers
                        int sumNum = addNum1 + addNum2;

                        //Displaying result
                        Console.WriteLine("\nThe sum of " + addNum1 + " and " + addNum2 + " is: " + sumNum + "\n");
                        break;

                    //Sine calculator code
                    case 3:

                        Console.WriteLine("\nYou chose Sine\nEnter an angle in radians:");

                        //User enters angle in radians
                        String radianWord = Console.ReadLine();
                        double radians = double.Parse(radianWord);

                        //Calculating the sine of the angle
                        double sine = Math.Sin(radians);

                        //Displaying result
                        Console.WriteLine("\nThe sine of " + radians + " radians is: " + sine + "\n");
                        break;

                    //Cosine calculator code
                    case 4:

                        Console.WriteLine("\nYou chose Cosine\nEnter and angle in radians");

                        //User enters angle in radians
                        String radianWord2 = Console.ReadLine();
                        double radians2 = double.Parse(radianWord2);

                        //Calculating the cosine of the angle
                        double cosine = Math.Sin(radians2);

                        //Displaying result
                        Console.WriteLine("\nThe cosine of " + radians2 + " radians is: " + cosine + "\n");
                        break;

                    //Absolute Value calculator code
                    case 5:

                        Console.WriteLine("\nYou chose Absolute Value\nEnter a number:");

                        //User enters number and program calculated absolute value
                        String absWord = Console.ReadLine();
                        int absolute = int.Parse(absWord);
                        int absoluteValue = Math.Abs(absolute);

                        //Displaying result
                        Console.WriteLine("\nThe absolute value of " + absolute + " is " + absoluteValue + "\n");
                        break;

                    case 6:
                        Console.WriteLine("\nGoodbye!");
                        play = false;
                        break;

                    default:
                        Console.WriteLine("\nYou did not enter a valid number, please try again\n");
                        break;
                }
            }

            //Keeps window open
            Console.ReadLine();
        }
    }
}
