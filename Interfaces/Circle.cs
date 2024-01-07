using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Circle : IPosition, IArea
    {
        //Fields
        protected double x;
        protected double y;
        protected double radius;

        //Parameterized constructor
        public Circle(double newX, double newY, double radii)
        {
            x = newX;
            y = newY;
            radius = radii;
        }

        //-------------------------------------------------
        //                  Properties
        //-------------------------------------------------

        //Radius Property
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

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

        //Area Property from IArea
        public double Area
        {
            get
            {
                return (radius * radius * Math.PI);
            }
        }

        //Perimeter Property from IArea
        public double Perimeter
        {
            get
            {
                return (2 * radius * Math.PI);
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

        //ContainsPosition method from IArea
        public bool ContainsPosition(IPosition position)
        {
            //Calculating the distance between the center of the circle and the oher position
            double distance = this.DistanceTo(position);

            //If the distance between the two is greater than the circle's radius, the method returns false
            if(distance > radius)
            {
                return false;
            }
            //If the distance between the two is less than or equal to the circle's radius, the method returns true
            else
            {
                return true;
            }
        }

        //IsLargerThan method from IArea
        public bool IsLargerThan(IArea areaToCheck)
        {
            //Calculating the area of the other object
            double otherArea = areaToCheck.Area;

            //If the area of this circle is greater than the other's, the method return true
            if(this.Area > otherArea)
            {
                return true;
            }
            //If the area of this circle is less than or equal to the other's, the method returns false
            else
            {
                return false;
            }
        }

        //Overriding ToString method
        public override string ToString()
        {
            return ("X coordinate of circle's center: " + x + "\nY coordinate of circle's center: " + y + "\nRadius of circle: " + this.Radius + "\nArea of circle: " + this.Area + "\nPerimeter of circle: " + this.Perimeter + "\n\n");
        }
    }
}
