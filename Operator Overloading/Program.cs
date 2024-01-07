using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating 2 vectors of each type
            Vector2 v1 = new Vector2(10, 10);
            Vector2 v2 = new Vector2(2, 4);
            Vector3 v3 = new Vector3(1.5, 2, 3.14159);
            Vector3 v4 = new Vector3(5, 5, 5);

            //Printing out the vectors
            Console.WriteLine("--- Initial Vectors ---");
            Console.WriteLine(v1.ToString());
            Console.WriteLine(v2.ToString());
            Console.WriteLine(v3.ToString());
            Console.WriteLine(v4.ToString());

            //Creating a list of Vector3's and adding the vectors to it
            List<Vector3> list = new List<Vector3>();
            list.Add((Vector3)v1);
            list.Add((Vector3)v2);
            list.Add(v3);
            list.Add(v4);

            //Testing each of the operators
            list[0] += list[1];
            list[1] -= list[0];
            list[2] *= 3;
            list[3] /= 5;

            //Printing out the changed vectors
            Console.WriteLine("\n\n\n--- Changed Vectors ---");
            foreach(Vector3 v in list)
            {
                Console.WriteLine(v.ToString());
            }

            //Casting and element within the list to Vector2 and printing it
            Vector2 v5 = list[2];
            Console.WriteLine("\n\n\n--- After Explicit Cast ---\nElement at index 2: " + v5.ToString());

            //Getting the average of the vectors in the list and printing it
            Vector3 v6 = new Vector3();
            foreach (Vector3 v in list)
            {
                v6 += v;
            }

            Console.WriteLine("\n\n\n--- Average ---\n" + v6.ToString());



            //Keeps the console window open
            Console.ReadLine();
        }
    }
}
