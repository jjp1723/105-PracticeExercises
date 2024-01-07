using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Point : IPosition
    {
        //Fields
        protected double x;
        protected double y;

        //Parameterized Constructor
        public Point(double newX, double newY)
        {
            x = newX;
            y = newY;
        }

        //-------------------------------------------------
        //                  Properties
        //-------------------------------------------------

        //X Property from IPosition
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        //Y Property from IPosition
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        //-------------------------------------------------
        //                  Methods
        //-------------------------------------------------

        //DistanceTo Method from IPosition
        public double DistanceTo(IPosition position)
        {
            //Assigning the x and y coordinates of the other position to a variable
            double otherX = position.X;
            double otherY = position.Y;

            //Ceating variables that will hold the distance between the x and y coordinates of the two position
            double distanceX = Math.Abs(otherX - x);
            double distanceY = Math.Abs(otherY - y);

            //Calculating total distance using the distance formula
            double totalDistance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));

            //Calculating and returning the direct distance based off the differences between x and y coordinates
            return totalDistance;
        }

        //MoveTo Method from IPosition
        public void MoveTo(double newX, double newY)
        {
            x = newX;
            y = newY;
        }

        //MoveBy Method from IPosition
        public void MoveBy(double xOffset, double yOffset)
        {
            x += xOffset;
            y += yOffset;
        }

        //Overriding ToString method
        public override string ToString()
        {
            return ("X coordinate of point: " + x + "\nY coordinate of point: " + y + "\n\n");
        }
    }
}
