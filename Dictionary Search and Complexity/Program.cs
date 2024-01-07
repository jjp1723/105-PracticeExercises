using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dictionary_Search_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the Distionary and the List
            List<string> wordList = new List<string>();
            Dictionary<string, bool> wordDictionary = new Dictionary<string, bool>();

            //Creating variables that represent the file
            FileStream instream = null;
            StreamReader input = null;

            //Creating the file stream and stream reader
            instream = File.OpenRead("words.txt");
            input = new StreamReader(instream);

            //Reading all the data in the file and adding it to the Dictionary and the List
            string word;
            while((word = input.ReadLine()) != null)
            {
                //Adding "word" to the Dictionary and List and setting its value to false in the Dictionary
                wordDictionary.Add(word, false);
                wordList.Add(word);
            }



            /*
            //Searching the List for duplicates
            foreach(string currentWord in wordList)
            {
                string dupeWord = currentWord + currentWord;

                if(wordList.Contains(dupeWord))
                {
                    Console.WriteLine(currentWord + " has a duplicate: " + dupeWord);
                }
            }

            Console.WriteLine("\nDone searching for duplicates!");
            */



            //Searching the Dictionary for duplicates
            foreach (string currentWord in wordList)
            {
                string dupeWord = currentWord + currentWord;

                if(wordDictionary.ContainsKey(dupeWord))
                {
                    Console.WriteLine(currentWord + " has a duplicate: " + dupeWord);

                    //Setting the word's entry to true
                    wordDictionary[dupeWord] = true;
                }
            }

            Console.WriteLine("\nDone searching for duplicates!");



            //Creating a loop that accpts input from the user and prints out whether the typed wprd is a duplicated word
            while(true)
            {
                //Prompting the user for input and assigning their input to a string
                Console.WriteLine("Please enter a word:");
                string inputWord = Console.ReadLine();

                //Try/Catch to make sure the word exists;  If it doesn't the code will report that it doesn't exist
                if(wordDictionary.ContainsKey(inputWord))
                {
                    //Response if the word is a duplicate word
                    if (wordDictionary[inputWord])
                    {
                        Console.WriteLine("\"" + inputWord + "\" is a duplicated word\n");
                    }

                    //If the user enters "done" or "quit", the program ends
                    else if (inputWord == "quit" || inputWord == "done")
                    {
                        break;
                    }

                    //Response if the word is not a duplicate word
                    else if (!wordDictionary[inputWord])
                    {
                        Console.WriteLine("\"" + inputWord + "\" is not a duplicated word\n");
                    }
                }
                else
                {
                    //Response if the word doesn't exist
                    Console.WriteLine("\"" + inputWord + "\" is not found\n");
                }
            }



            //Keeping the Console Window Open
            Console.WriteLine("\n\nGoodbye!");
            Console.ReadLine();
        }
    }
}
