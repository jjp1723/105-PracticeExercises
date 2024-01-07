using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the list with a negative number to cause an error
            BetterCustomList<string> myList;

            try
            {
                myList = new BetterCustomList<string>(-1);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                myList = new BetterCustomList<string>();
            }

            //Adding names to the list
            myList.Add("John");
            myList.Add("Chris");
            myList.Add("Maria");

            //Printing out the indicies, two of which are invalid
            try
            {
                Console.WriteLine("\nPrinting names in list: \n" + myList[0]);
                Console.WriteLine(myList[9]);
                Console.WriteLine(myList[-3]);
            }
            catch
            {
                Console.WriteLine("Error!  Stopping all code in TRY");
            }

            //Informing the user that the program has ended
            Console.WriteLine("\nDone!");



            //Keeps console window open
            Console.ReadLine();
        }
    }
}
