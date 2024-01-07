using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome!
            Console.WriteLine("Welcome to the Fight!\n\n");

            //Creating the two monster that will be fighting
            Random rng = new Random();
            Dragon smaug = new Dragon(115, Damage.Fire, "Smaug", rng);
            Beholder bilbo = new Beholder(90, Damage.Earth, "Bilbo", rng);
            Console.WriteLine(smaug.ToString() + "\n" + bilbo.ToString() + "\n");
            string victor = "";

            //Looped fight
            bool alive = true;
            while(alive)
            {
                //Smaug's attack
                int smaugDMG = smaug.Attack();
                bilbo.Health = bilbo.Health - smaugDMG;
                Console.WriteLine(smaug.Name + " attacks for " + smaugDMG + " damage.  " + bilbo.Name + "'s health: " + bilbo.Health);

                //Checks to see if Bilbo is still alive
                if (bilbo.Health == 0)
                {
                    victor = smaug.Name;
                    alive = false;
                    break;
                }

                //Bilbo's attack
                int bilboDMG = bilbo.Attack();
                smaug.Health = smaug.Health - bilboDMG;
                Console.WriteLine(bilbo.Name + " attacks for " + bilboDMG + " damage.  " + smaug.Name + "'s health: " + smaug.Health);

                //Checks to see if Smaug is still alive
                if (smaug.Health == 0)
                {
                    victor = bilbo.Name;
                    alive = false;
                    break;
                }
            }

            //Prints the victor
            Console.WriteLine("\n" + victor + " has emerged victorious!");



            //Keeps console window open
            Console.ReadLine();
        }
    }
}
