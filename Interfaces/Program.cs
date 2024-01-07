using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating two Points and two Circles
            Point point1 = new Point(48.9, 12.3);
            Point point2 = new Point(42, 69);
            Circle circle1 = new Circle(46.3, 57.8, 12.4);
            Circle circle2 = new Circle(10, 10, 8);

            //Printing initial data for all for objects
            Console.WriteLine("Point 1:\n" + point1.ToString() + "Point 2:\n" + point2.ToString() + "Circle 1:\n" + circle1.ToString() + "Circle 2:\n" + circle2.ToString());

            //Moving point2 and circle2
            Console.WriteLine("\nMoving point 2 to (45, 52.8)");
            point2.MoveTo(45, 52.8);
            Console.WriteLine("Moving circle 2 by (37.6, 7)");
            circle2.MoveBy(37.6, 7);

            //Printing data for all for objects again
            Console.WriteLine("\n\n\nPoint 1:\n" + point1.ToString() + "Point 2:\n" + point2.ToString() + "Circle 1:\n" + circle1.ToString() + "Circle 2:\n" + circle2.ToString());

            //Checking the distance between the two points and each circle and each point
            Console.WriteLine("\nDistance between the two points: " + point1.DistanceTo(point2));
            Console.WriteLine("Distance between the two circles: " + circle1.DistanceTo(circle2));
            Console.WriteLine("Distance between circle 1 and point 1: " + circle1.DistanceTo(point1));
            Console.WriteLine("Distance between circle 1 and point 2: " + circle1.DistanceTo(point2));
            Console.WriteLine("Distance between circle 2 and point 1: " + circle2.DistanceTo(point1));
            Console.WriteLine("Distance between circle 2 and point 2: " + circle2.DistanceTo(point2));

            //Determining which circle has a larger area
            Console.WriteLine("\n\n\nCircle 1's area: " + circle1.Area);
            Console.WriteLine("Circle 2's area: " + circle2.Area);

            if(circle1.Area > circle2.Area)
            {
                Console.WriteLine("\nCircle 1 has a larger area than circle 2\n\n\n");
            }
            else if(circle2.Area > circle1.Area)
            {
                Console.WriteLine("\nCircle 2 has a larger area than circle 1\n\n\n");
            }
            else
            {
                Console.WriteLine("The two circle have the same area\n\n\n");
            }

            //Determining whether the circles contain either point
            Console.Write("Does circle 1 conain point 1?  ");
            if(circle1.ContainsPosition(point1))
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            Console.Write("Does circle 1 conain point 2?  ");
            if (circle1.ContainsPosition(point2))
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            Console.Write("Does circle 2 conain point 1?  ");
            if (circle2.ContainsPosition(point1))
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }

            Console.Write("Does circle 2 conain point 2?  ");
            if (circle2.ContainsPosition(point2))
            {
                Console.WriteLine("Yes!");
            }
            else
            {
                Console.WriteLine("No!");
            }



            //Keeps console window open
            Console.ReadLine();
        }
    }
}
