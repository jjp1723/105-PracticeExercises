using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_and_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user to enter a list size

            int big = 0;
            string size = "";

            bool parseable = true;
            while(parseable)
            {
                Console.WriteLine("List size?");
                size = Console.ReadLine();
                int value = 0;
                if (int.TryParse(size, out value) == true)
                {
                    big = int.Parse(size);
                    parseable = false;
                }
                else
                {
                    Console.WriteLine("\nYou did not enter a number, try again\n");
                }
                
            }

            CustomList<string> myList = new CustomList<string>(big);
            Console.WriteLine("The list size is " + size);

            //Keeps the program running until the user enters "done"
            bool play = true;
            while (play)
            {
                //Prompting the user to enter an item
                Console.WriteLine("Enter an item:\n");
                string word = Console.ReadLine();

                //If the user enters "print", the print method is executed
                if (word == "print")
                {
                    myList.Print();
                }

                //If the user enters "count", the count property is called
                else if (word == "count")
                {
                    Console.WriteLine("Count: " + myList.Count);
                }

                //If the user enters "capacity", the capacity property is called
                else if (word == "capacity")
                {
                    Console.WriteLine("Capacity: " + myList.Capacity);
                }

                //If the user enters "get", the get property is used
                else if(word == "get")
                {
                    int indexGet = 0;
                    string theWord = "";

                    //Ensures the user inputs an integer
                    bool parseGet = true;
                    while (parseGet)
                    {
                        Console.WriteLine("Which index?");
                        theWord = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(theWord, out value) == true)
                        {
                            indexGet = int.Parse(theWord);
                            parseGet = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }

                    }
                    
                    //Gets the string at the index
                    Console.WriteLine((string)(object)myList[indexGet]);
                }

                //If the user enters "set", the set property is used
                else if (word == "set")
                {
                    //Ensures the user inputs an integer
                    int indexSet = 0;
                    string theOtherWord = "";

                    bool parseSet = true;
                    while (parseSet)
                    {
                        Console.WriteLine("Which index?");
                        theOtherWord = Console.ReadLine();
                        int value = 0;
                        if (int.TryParse(theOtherWord, out value) == true)
                        {
                            indexSet = int.Parse(theOtherWord);
                            parseSet = false;
                        }
                        else
                        {
                            Console.WriteLine("\nYou did not enter a number, try again\n");
                        }
                    }

                    //Asks the user what they want to set this index to
                    Console.WriteLine("What should this index be set to?");
                    string setWord = Console.ReadLine();
                    myList[indexSet] = setWord;
                }

                //If the user enters "done", the program stops
                else if (word == "done")
                {
                    Console.WriteLine("Goodbye!");
                    play = false;
                }
                else
                {
                    myList.Add(word);
                }
            }



            //Testing generic with an <int> custom list
            CustomList<int> intList = new CustomList<int>(5);
            intList.Add(3);
            intList.Add(7);
            Console.WriteLine("Current count: " + intList.Count);
            intList.Add(74);
            intList.Add(420);
            intList.Add(123456789);
            Console.WriteLine("Capacity: " + intList.Capacity);
            intList.Print();



            //Keeps window open
            Console.ReadLine();
        }
    }
}
