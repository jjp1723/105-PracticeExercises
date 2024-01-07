using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the warrior, Stanley
            Warrior stanley = new Warrior(3, "Stanley", 30, 20, 2);
            stanley.PrintWarrior();

            //Creating the wizard, Taako
            Wizard taako = new Wizard(20, "Taako", 20, 6, 50);
            taako.PrintWizard();

            //Creating the thief, Vax
            Thief vax = new Thief(6, "Vax", 10, 30, 30);
            vax.PrintThief();

            Console.WriteLine("\n\n");

            //Performing special moves
            stanley.SpecialMove();
            taako.SpecialMove();
            vax.SpecialMove();

            Console.WriteLine("\n\n");

            //Changing Stanley's stats
            stanley.Strength = 40;
            stanley.Dexterity = 25;
            stanley.Intelligence = 5;
            stanley.Bath = 1;

            //Changing Taako's stats
            taako.Strength = 15;
            taako.Dexterity = 12;
            taako.Intelligence = 72;
            taako.HotPocket = 80;

            //Chaning Vax's stats
            vax.Strength = 17;
            vax.Dexterity = 33;
            vax.Intelligence = 26;
            vax.CellPhone = 3;

            //Printing new stats
            stanley.PrintWarrior();
            taako.PrintWizard();
            vax.PrintThief();

            Console.WriteLine("\n\n");

            //Performing special moves one more time
            stanley.SpecialMove();
            taako.SpecialMove();
            vax.SpecialMove();



            //Keeps window open
            Console.ReadLine();
        }
    }
}
