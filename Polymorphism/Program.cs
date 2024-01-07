using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a list of characters and adding one of each type to it
            List<Character> rpgList = new List<Character>();

            Random rngesus = new Random();

            rpgList.Add(new Warrior(3, "Stanley", 30, 20, 2));
            rpgList.Add(new Wizard(50, rngesus, "Taako", 20, 6, 50));
            rpgList.Add(new Thief(7, "Vax", 10, 30, 30));

            //Creating a loop to test polymorphism within the List
            Random rng = new Random();
            for(int repeat = 0; repeat < 10; repeat++)
            {
                //Creating a visible separation between random characters
                Console.WriteLine("\n---------- Random Character ----------\n\n");

                int index = (int)rng.Next(3);

                //ToString
                Console.WriteLine(rpgList[index].ToString());

                //SpecialMove
                rpgList[index].SpecialMove();

                //Unique method for Warrior
                if(rpgList[index] is Warrior)
                {
                    Warrior stanley = (Warrior)rpgList[index];
                    stanley.TakeBath();
                    rpgList[index] = stanley;
                }

                //Unique method for Wizard
                if(rpgList[index] is Wizard)
                {
                    Wizard taako = (Wizard)rpgList[index];
                    taako.EatPocket();
                    rpgList[index] = taako;
                }

                //Unique method fo Thief
                if(rpgList[index] is Thief)
                {
                    Thief vax = (Thief)rpgList[index];
                    vax.CallBlock();
                    rpgList[index] = vax;
                }
            }



            //Keeps console open
            Console.ReadLine();
        }
    }
}
