using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Name_Generation
{
    class NameGenerator
    {
        //Fields
        private int longest;
        private int shortest;
        private int total;
        private Random generator;

        //Lists of name parts
        private List<string> firstOne = new List<string>();
        private List<string> firstTwo = new List<string>();
        private List<string> lastOne = new List<string>();
        private List<string> lastTwo = new List<string>();
        private List<string> lastThree = new List<string>();

        //Intantiates an object
        public NameGenerator(Random rng)
        {
            generator = rng;
            longest = 0;
            shortest = 0;
            total = 0;
            
            //First List
            firstOne.Add("Bob");
            firstOne.Add("Tom");
            firstOne.Add("Jim");
            firstOne.Add("Sal");
            firstOne.Add("Scan");
            firstOne.Add("Lee");

            //Second List
            firstTwo.Add("bert");
            firstTwo.Add("othy");
            firstTwo.Add("bo");
            firstTwo.Add("lan");

            //Third List
            lastOne.Add("Flo");
            lastOne.Add("Reg");
            lastOne.Add("Smi");
            lastOne.Add("Pru");
            lastOne.Add("Sho");

            //Fourth List
            lastTwo.Add("gon");
            lastTwo.Add("spin");
            lastTwo.Add("jum");
            lastTwo.Add("a");

            //Fifth List
            lastThree.Add("lerg");
            lastThree.Add("ong");
            lastThree.Add("kin");
            lastThree.Add("floon");
            lastThree.Add("ski");
        }

        //Generate Method
        public string GenerateName()
        {
            //Using random to select name pieces from the lists
            int selectOne = generator.Next(6);
            string f1 = firstOne[selectOne];

            int selectTwo = generator.Next(4);
            string f2 = firstTwo[selectTwo];

            int selectThree = generator.Next(5);
            string l1 = lastOne[selectThree];

            int selectFour = generator.Next(4);
            string l2 = lastTwo[selectFour];

            int selectFive = generator.Next(5);
            string l3 = lastThree[selectFive];

            string name = f1 + f2 + " " + l1 + l2 + l3;

            int nameLength = name.Length;

            //Determining is the name is the longest or shortest generated
            if(nameLength > longest)
            {
                longest = nameLength;
            }
            if(nameLength < shortest)
            {
                shortest = nameLength;
            }
            else if(shortest == 0)
            {
                shortest = nameLength;
            }

            total++;

            return name;
        }

        //Print method
        public void PrintStatistics()
        {
            Console.WriteLine("The shortest name is " + shortest + " characters");
            Console.WriteLine("The longest name is " + longest + " characters");
            Console.WriteLine(total + " character names were generated");
        }
    }
}