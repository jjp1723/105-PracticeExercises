using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompting the user to enter names, which are then entered into the array
            Console.WriteLine("How many names do you wish to enter?");
            string numNameWord = Console.ReadLine();
            int numName = int.Parse(numNameWord);
            string[] nameRay = new string[numName];

            //Loop for entering names into the array
            for(int i = 0; i < numName; i++)
            {
                Console.WriteLine("Please Enter a name");
                nameRay[i] = Console.ReadLine();
            }

            //Creating a boolean for the loop
            bool play = true;

            //Creating a loop to kepp program running as long as the user wants
            while(play)
            {
                Console.WriteLine("Choose from one of the following choices:\n1 - Print all names\t 2 - Name search\t3 - Replace a name\t4 - Find duplicates\t5 - Quit");
                string numChoiceWord = Console.ReadLine();
                int numChoice = 0;
                
                if (int.TryParse(numChoiceWord, out numChoice) == true)
                {
                    numChoice = int.Parse(numChoiceWord);
                }
                else
                {
                    Console.WriteLine("\nYou did not enter a number, try again\n");
                }

                switch (numChoice)
                {
                    //Code for Print all names
                    case 1:
                        //Foreach loop print all names in the array
                        foreach(string j in nameRay)
                        {
                            Console.WriteLine(j);
                        }
                        break;

                    //Code for Search for a name
                    case 2:
                        //Prompting the user for what name they want to search for
                        Console.WriteLine("What name would you like to search for?");
                        string nameSearch = Console.ReadLine();

                        //Foreach loop searches array for the name
                        bool found = false;

                        foreach (string k in nameRay)
                        {
                            if(k == nameSearch)
                            {
                                found = true;
                                break;
                            }
                        }

                        if(found == true)
                        {
                            Console.WriteLine(nameSearch + " was found!");
                        }
                        else
                        {
                            Console.WriteLine("Sorry, could not find " + nameSearch);
                        }
                        break;

                    //Code for replace a name
                    case 3:
                        //Creating a boolean and while loop to validate that the user enters a valid index
                        int numDex = 0;

                        bool index = false;
                        while(!index)
                        {
                            Console.WriteLine("Please enter a valid index within the array for the name you would like to replace");
                            string numDexWord = Console.ReadLine();
                            numDex = int.Parse(numDexWord);

                            if((numDex >= 0) && (numDex <= numName))
                            {
                                index = true;
                            }
                            else
                            {
                                Console.WriteLine("Not a valid index.  Please try again");
                            }
                        }

                        //Performing the replacement
                        Console.WriteLine("What name would you like to replace this index with?");
                        string namePlace = Console.ReadLine();
                        Console.WriteLine("The old name was: " + nameRay[numDex] + "\nThe new name is: " + namePlace);
                        nameRay[numDex] = namePlace;
                        break;

                    //Code for Finding Duplicates
                    case 4:
                        //Establish a new array for the duplicates
                        string[] duplicateRay = new string[numName];
                        int duplicate = 0;

                        //Using nested loops to search the array
                        for (int l = 0; l < numName; l++)
                        {
                            //Boolean to determine if current string being searched for duplicates hasn't been searched before
                            bool repeat = false;

                            //For loop to search duplicate array to see if current string has been searched for before
                            for (int n = 0; n < numName; n++)
                            {
                                //If the current string is NOT found in duplicate array, the boolean remains false
                                if (nameRay[l] != duplicateRay[n])
                                {
                                    repeat = false;
                                }

                                //If the current string IS found in the duplicate array, the boolean is changed to true
                                else
                                {
                                    repeat = true;
                                    break;
                                }
                            }

                            //If the boolean is still false (string wasn't found in duplicate array), the program searched the name array for duplicates of the given string
                            if(repeat == false)
                            {
                                for (int m = l + 1; m < numName; m++)
                                {
                                    //If a duplicate is found, it is added to the duplicate array and breaks off the search for additional duplicates of the same string
                                    if (nameRay[l] == nameRay[m])
                                    {
                                        duplicateRay[duplicate] = nameRay[m];
                                        duplicate++;
                                        break;
                                    }
                                }
                            }
                        }

                        //Prints all duplicates found
                        foreach (string o in duplicateRay)
                        {
                            Console.WriteLine(o);
                        }
                        break;

                    case 5:
                        play = false;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("You did not enter a valid selection, try again");
                        break;
                }
            }



            //Keeps the window open
            Console.ReadLine();
        }
    }
}
