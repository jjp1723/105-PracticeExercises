using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Binary_File_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating PlayerManager Object
            PlayerManager myManager = new PlayerManager();

            //Creating a loop to get input from the user
            bool quitter = false;
            while (!quitter)
            {
                //Prompting the user for input
                Console.WriteLine("Choose one of the following options:\nCreate\tPrint\tSave\tLoad\tInfo\tQuit\n");
                string response = Console.ReadLine().ToLower();

                //Using a Switch for all posible inputs
                switch (response)
                {
                    //Code for "create" input
                    case "create":
                        Console.WriteLine("What is the player's name?");
                        myManager.CreatePlayer(Console.ReadLine());
                        break;

                    //Code for "print" input
                    case "print":
                        myManager.Print();
                        break;

                    //Code for "save" input
                    case "save":
                        myManager.Save();
                        break;

                    //Code for "load" input
                    case "load":
                        myManager.Load();
                        break;

                    //Code for "info" input
                    case "info":
                        if(File.Exists("players.data"))
                        {
                            Console.WriteLine("Created at: " + File.GetCreationTime("players.data"));
                            Console.WriteLine("File last accessed: " + File.GetLastAccessTime("players.data"));
                        }
                        else
                        {
                            Console.WriteLine("In order to check info of the file, you must create/save it first");
                        }
                        break;

                    //Code for "quit" input
                    case "quit":
                        Console.WriteLine("Have a nice day!");
                        quitter = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, that is not a valid choice\n");
                        break;
                }
            }



            //Keeps Console Window Open
            Console.ReadLine();
        }
    }
}
