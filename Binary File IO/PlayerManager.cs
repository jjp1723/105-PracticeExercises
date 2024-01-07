using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_File_IO
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
            //Creating file stream
            FileStream outstream = File.OpenWrite("players.data");

            //Creating stream writer
            BinaryWriter output = new BinaryWriter(outstream);

            //Implemeting try/catch for any potential errors
            try
            {

                //Writing how many players are in the file
                output.Write(team.Count);

                //Writing data into stream object
                foreach (Player teammate in team)
                {
                    output.Write(teammate.Name);
                    output.Write(teammate.Attack);
                    output.Write(teammate.Weight);
                }
                
                Console.WriteLine("Saved players to the list\n");
            }
            catch
            {
                Console.WriteLine("Error: Incomplete Save\nMake sure you have added players to the team before saving");
            }

            //Closing the reader/stream
            finally
            {
                output.Close();
            }
        }



        //Load Method
        public void Load()
        {
            //Clearing the List<Player> of players
            team.Clear();

            //Creating variables that represent the file before try/catch
            FileStream inStream = null;
            BinaryReader input = null;

            //Create file stream
            inStream = File.OpenRead("players.data");

            //Creating stream reader
            input = new BinaryReader(inStream);

            //Reading all the data to create new player objects
            int size = input.ReadInt32();

            //Implementing try/catch for any potential errors
            try
            {
                for (int i = 0; i < size; i++)
                {
                    //Creating new player using data
                    Player veteran = new Player(input.ReadString());
                    veteran.Attack = input.ReadInt32();
                    veteran.Weight = input.ReadDouble();

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
                if (input != null)
                {
                    input.Close();
                }
            }
        }
    }
}
