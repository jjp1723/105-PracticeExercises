using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user to enter a list size
            Console.WriteLine("List size?");
            string size = Console.ReadLine();
            int big = int.Parse(size);

            CustomList myList = new CustomList(big);
            Console.WriteLine("The list size is " + size);

            //Keeps the program running until the user enters "done"
            bool play = true;
            while(play)
            {
                //Prompting the user to enter an item
                Console.WriteLine("Enter an item:\n");
                string word = Console.ReadLine();

                //If the user enters "print", the print method is executed
                if(word == "print")
                {
                    myList.Print();
                }

                //If the user enters "count", the count property is called
                else if(word == "count")
                {
                    Console.WriteLine("Count: " + myList.Count);
                }
                
                //If the user enters "capacity", the capacity property is called
                else if(word == "capacity")
                {
                    Console.WriteLine("Capacity: " + myList.Capacity);
                }

                //If the user enters "done", the program stops
                else if(word == "done")
                {
                    Console.WriteLine("Goodbye!");
                    play = false;
                }
                else
                {
                    myList.Add(word);
                }
            }



            //Keeps window open
            Console.ReadLine();
        }
    }
}
