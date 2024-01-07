using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_and_Delegates
{
    //Creating a Delegate
    delegate void MessageDelegate(string label, string message);

    class Program
    {
        static void Main(string[] args)
        {
            //Creating MessageLog object and Die object
            MessageLog log = new MessageLog();
            Die die = new Die();

            //Hooking up RolledATwenty to the MessageLog
            die.RolledATwenty += log.Save;

            //Rolling 100 dice and printing each roll
            for(int rolls = 0; rolls < 100; rolls++)
            {
                Console.WriteLine(die.RollDie());
            }

            //Printing the MessageLog
            Console.WriteLine("\n\nPrinting Message Log:");
            log.Print();



            //Keeps the Console Window Open
            Console.ReadLine();
        }
    }
}
