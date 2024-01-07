using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Propmting the user to enter their name
            Console.WriteLine("Hi there, I'd like to analyze your name.  Please enter it:");
            string userName = Console.ReadLine();

            //Printing name in all caps
            Console.WriteLine("Thank you " + userName.ToUpper());

            //First and last letter of their name
            int nameLength = userName.Length;
            Console.WriteLine("The first letter of you name is " + userName[0] + "\nThe last letter of your name is " + userName[nameLength - 1]);

            //Length of their name
            Console.WriteLine("The length of your name is " + nameLength);

            //Name in reverse
            Console.Write("Your name in reverse is ");
            for(int nameIndex = nameLength - 1; nameIndex > -1; nameIndex--)
            {
                Console.Write(userName[nameIndex]);
            }



            //Prompting the user to enter a price
            double currency = 0;
            string input;

            //Makes sure the user enters a value that functions as a double
            Console.WriteLine("\n\nNow I'm going to analyze some numbers.  Please enter a price:");

            while (true)
            {
                input = Console.ReadLine();
                if (double.TryParse(input, out currency))
                {
                    currency = double.Parse(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you did not enter a valid price, try again");
                }
            }

            //Converting to monetary value
            string money = currency.ToString("C2");
            Console.WriteLine("You entered " + money);

            //Adding tax
            double taxes = currency + currency * 0.04;
            string taxMoney = taxes.ToString("C2");
            Console.WriteLine("Total with tax " + taxMoney);

            //Splitting dollar and cents value
            int dollar = (int)taxes;
            int taxLength = taxMoney.Length;
            Console.WriteLine("The dollar portion: " + dollar);
            Console.WriteLine("The cents portion: 0" + taxMoney.Substring(taxLength - 3, taxLength - 2));



            //Comparing two numbers
            Console.WriteLine("\nNow we'll compare two numbers");

            //Entering the first number
            Console.WriteLine("Please enter the first number");
            string num1;
            double number1 = 0;

            while (true)
            {
                num1 = Console.ReadLine();
                if (double.TryParse(num1, out number1))
                {
                    number1 = double.Parse(num1);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you did not enter a valid number, try again");
                }
            }

            //Entering the second number
            Console.WriteLine("Please enter the second number");
            string num2;
            double number2 = 0;

            while (true)
            {
                num2 = Console.ReadLine();
                if (double.TryParse(num2, out number2))
                {
                    number2 = double.Parse(num2);
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you did not enter a valid number, try again");
                }
            }

            //Comparison
            if(number1 > number2)
            {
                Console.WriteLine("The larger number is: " + number1);
            }
            else if(number2 > number1)
            {
                Console.WriteLine("The larger number is: " + number2);
            }
            else
            {
                Console.WriteLine("The numbers are the same");
            }

            //Altering a sentence
            Console.WriteLine("\nLets alter a larger sentence (no puntuation necessary)");
            Console.WriteLine("Please enter a sentence");
            string sentence = Console.ReadLine();

            //Splitting sentence and printing it backwards
            string[] sentenceWords = sentence.Split(' ');
            int totalWords = sentenceWords.Length;
            Console.Write("Sentence reversed:");

            for(int word = totalWords - 1; word > -1; word--)
            {
                Console.Write(sentenceWords[word] + " ");
            }



            //Keeps the window open
            Console.ReadLine();
        }
    }
}
