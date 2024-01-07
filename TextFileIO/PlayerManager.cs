using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TextFileIO
{
    class PlayerManager
    {
        //Fields
        protected List<Player> team;



        //Constructor
        public PlayerManager()
        {
            team = new List<Player>();
        }



        //Create Method
        public void CreatePlayer(string name)
        {
            team.Add(new Player(name));
            Console.WriteLine("Added " + name + " to the list.\n");
        }



        //Print Method
        public void Print()
        {
            foreach (Player teammate in team)
            {
                Console.WriteLine("\n" + teammate.ToString());
            }
        }



        //Save Method
        public void Save()
        {
            //Implemeting try/catch for any potential errors
            try
            {
                //Creating file stream
                FileStream outstream = File.OpenWrite("TeamList.txt");

                //Creating stream writer
                StreamWriter output = new StreamWriter(outstream);

                //Writing data into stream object
                foreach (Player teammate in team)
                {
                    output.WriteLine(teammate.Name + "," + teammate.Attack + "," + teammate.Defense);
                }

                //Closing the writer
                output.Close();
                Console.WriteLine("Saved players to the list\n");
            }
            catch
            {
                Console.WriteLine("Error: Incomplete Save\nMake sure you have added players to the team before saving");
            }
        }



        //Load Method
        public void Load()
        {
            //Clearing the List<Player> of players
            team.Clear();

            //Creating variables that represent the file before try/catch
            FileStream inStream = null;
            StreamReader input = null;

            //Create file stream
            inStream = File.OpenRead("TeamList.txt");

            //Creating stream reader
            input = new StreamReader(inStream);

            //Implementing try/catch for any potential errors
            try
            {
                //Reading all the data to create new player objects
                string line;
                while ((line = input.ReadLine()) != null)
                {
                    //Using split method to separate data
                    string[] stats = line.Split(',');

                    //Creating new player using data
                    Player veteran = new Player(stats[0]);
                    veteran.Attack = int.Parse(stats[1]);
                    veteran.Defense = int.Parse(stats[2]);

                    //Adding the player to the List<Player>
                    team.Add(veteran);
                }
            }
            catch
            {
                Console.WriteLine("Error: Incomplete Load\nMake sure you have saved player data before attempting to load");
            }

            //Closing the reader/stream
            finally
            {
                if(input != null)
                {
                    input.Close();
                }
            }
        }
    }
}
