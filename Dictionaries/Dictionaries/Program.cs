using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------- Part 1 ---------------
            Console.WriteLine("--------------- Part 1 ---------------\n\n");


            //Creating Dictionary Object
            Dictionary<string, Player> playerDictionary = new Dictionary<string, Player>();

            //Creating new Players
            Player tom = new Player("Tom", 105);
            Player jim = new Player("Jim", 62);
            Player pam = new Player("Pam", 116);

            //Adding Players to the dictionary
            playerDictionary.Add(tom.Name, tom);
            playerDictionary.Add(jim.Name, jim);
            playerDictionary.Add(pam.Name, pam);

            //Creating loop to ask the user for names
            while (true)
            {
                Console.WriteLine("Please enter a name: ");
                string input = Console.ReadLine();

                //Checking is the user's input is one of the Player's names or either "done" or "quit"
                if (playerDictionary.ContainsKey(input))
                {
                    Console.WriteLine("\n\nFound " + input + "\n" + playerDictionary[input].ToString() + "\n\n");
                }
                else if (input.ToLower() == "done" || input.ToLower() == "quit")
                {
                    Console.WriteLine("\n\n\n--------------- Part 1 Complete! ---------------");
                    break;
                }
                else
                {
                    Console.WriteLine("\n\n" + input + " not found\n\n");
                }
            }





            // --------------- Part 2 ---------------
            Console.WriteLine("\n\n\n--------------- Part 2 ---------------\n\n");

            //Creating Stopwatch Object
            Stopwatch stopwatch = new Stopwatch();

            //Clearing the Player Dictionary and creating a Player List
            playerDictionary.Clear();
            List<Player> playerList = new List<Player>();

            //Creating a random object that will be used to generate player scores
            Random rng = new Random();

            //Using a loop to create 100000 Player objects with names "p0" - "p99" and with random scores
            string lastPlayerName = "";
            for(int loop = 0; loop < 100000; loop++)
            {
                //Creating player names and sores
                string playerName = "p" + loop;
                int playerScore = (int)rng.Next(151);

                //Adding players to the List and Dictionary
                playerList.Add(new Player(playerName, playerScore));
                playerDictionary.Add(playerName, new Player(playerName, playerScore));

                //Storing the name of the last player to search for
                lastPlayerName = playerName;
            }

            //Using the Stopwatch to time how long it takes to search for the last Player in the Dictionary
            stopwatch.Start();
            Player lastPlayer = playerDictionary[lastPlayerName];
            stopwatch.Stop();
            double dictionaryTime = stopwatch.Elapsed.TotalMilliseconds;

            //Reporting time for searching the dictionary
            Console.WriteLine("Time needed to search: " + dictionaryTime + " seconds\n");

            //Using the Stopwatch to time how long it takes to search for the last Player in the List
            double listTime = 0;
            stopwatch.Restart();
            foreach(Player player in playerList)
            {
                if(player.Name == lastPlayerName)
                {
                    Console.WriteLine("Player found in list!");
                    stopwatch.Stop();
                    listTime = stopwatch.Elapsed.TotalMilliseconds;
                    break;
                }
            }

            //Reporting time for searching the list
            Console.WriteLine("Time needed to search: " + listTime + " seconds");



            //Keeps Console Window Open
            Console.ReadLine();
        }
    }
}
