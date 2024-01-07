using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //String method testing
            string stringForTesting = "This is a sentence";

            stringForTesting = stringForTesting.Replace("s", "S");
            Console.WriteLine(stringForTesting);

            stringForTesting = stringForTesting.ToUpper();
            Console.WriteLine(stringForTesting);

            stringForTesting = stringForTesting.Remove(4, 10);
            Console.WriteLine(stringForTesting);

            //Testing formatting options
            double money = 4321.232423;
            string currency = money.ToString("C2");
            Console.WriteLine("\n" + currency + "\n");

            string output = "The price is {0} for your {1}";
            string item = "Roomba";

            string combinedOutput = String.Format(output, currency, item);
            Console.WriteLine(combinedOutput);



            //Keeps the window open
            Console.ReadLine();
        }
    }
}
