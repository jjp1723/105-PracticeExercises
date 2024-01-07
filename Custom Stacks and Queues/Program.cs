using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Stacks_and_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testing GameStack
            //Creating a stack of spells and adding spells to it
            GameStack<string> spellStack = new GameStack<string>();

            Console.WriteLine("The following spells are being put on the stack:\n");

            spellStack.Push("Shock");
            Console.WriteLine("\t-\t" + spellStack.Peek());

            spellStack.Push("Fork");
            Console.WriteLine("\t-\t" + spellStack.Peek());

            spellStack.Push("Counterspell");
            Console.WriteLine("\t-\t" + spellStack.Peek());

            spellStack.Push("Force of Will");
            Console.WriteLine("\t-\t" + spellStack.Peek());

            spellStack.Push("Deflection");
            Console.WriteLine("\t-\t" + spellStack.Peek());

            //Resolving the spells with Pop method with a foreach loop
            Console.WriteLine("\n\nSpells resolving (in reverse order):\n");

            for(int j = spellStack.Count - 1; j >= 0; j--)
            {
                Console.WriteLine("\t-\t" + spellStack.Pop());
            }



            //Testing GameQueue
            //Creating a queue of players and then adding to it
            GameQueue<string> playerQueue = new GameQueue<string>();

            Console.WriteLine("\n\n\nAdding the following players to the queue:\n");

            playerQueue.Enqueue("Bob");
            Console.WriteLine("\t-\t" + playerQueue.Peek());

            playerQueue.Enqueue("Tom");
            Console.WriteLine("\t-\t" + "Tom");

            playerQueue.Enqueue("Sara");
            Console.WriteLine("\t-\t" + "Sara");

            playerQueue.Enqueue("Jim");
            Console.WriteLine("\t-\t" + "Jim");

            playerQueue.Enqueue("Larry");
            Console.WriteLine("\t-\t" + "Larry\n\n");

            //Dequeueing players withing the queue
            for (int k = playerQueue.Count - 1; k >= 0; k--)
            {
                Console.WriteLine(playerQueue.Dequeue() + " has joined the server:\t" + playerQueue.Count + " player(s) left in the queue");
            }



            //Keeps Console Window Open
            Console.ReadLine();
        }
    }
}
