using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Vector2
    {
        //Fields
        protected double x;
        protected double y;



        //Field Properties

        //X Property
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

        //Y Property
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



        //Constructors

        //Default Constructor
        public Vector2()
        {
            x = 0;
            y = 0;
        }

        //Parameterized Constructor
        public Vector2(double exx, double why)
        {
            x = exx;
            y = why;
        }



        //Methods

        //Override ToString
        public override string ToString()
        {
            return ("(" + x + ", " + y + ")");
        }



        //Operators

        //Vector + Vector   Operator
        public static Vector2 operator + (Vector2 v1, Vector2 v2)
        {
            //Create the brand new vector
            Vector2 v3 = new Vector2();

            //Adding the 'x' values of the two vectors
            v3.X = v1.X + v2.X;

            //Adding the 'y' values of the two vectors
            v3.Y = v1.Y + v2.Y;

            //Returning the new vector
            return v3;
        }

        //Vector - Vector   Operator
        public static Vector2 operator - (Vector2 v1, Vector2 v2)
        {
            //Create the brand new vector
            Vector2 v3 = new Vector2();

            //Adding the 'x' values of the two vectors
            v3.X = v1.X - v2.X;

            //Adding the 'y' values of the two vectors
            v3.Y = v1.Y - v2.Y;

            //Returning the new vector
            return v3;
        }

        //Vector * Scalar   Operator
        public static Vector2 operator * (Vector2 v1, int scalar)
        {
            //Create the brand new vector
            Vector2 v2 = new Vector2();

            //Multiplying the 'x' value of the vector by the scalar
            v2.X = v1.X * scalar;

            //Multiplying the 'y' value of the vector by the scalar
            v2.Y = v1.Y * scalar;

            //Returning the new vector
            return v2;
        }

        //Vector / Scalar   Operator
        public static Vector2 operator / (Vector2 v1, int scalar)
        {
            //Create the brand new vector
            Vector2 v2 = new Vector2();

            //Dividing the 'x' value of the vector by the scalar
            v2.X = v1.X / scalar;

            //Dividing the 'y' value of the vector by the scalar
            v2.Y = v1.Y / scalar;

            //Returning the new vector
            return v2;
        }

        //Vector3 -> Vector2    Conversion Operator
        public static implicit operator Vector2 (Vector3 v1)
        {
            //Create the brand new vector
            Vector2 v2 = new Vector2();

            //Multiplying the 'x' values of the vector by the scalar
            v2.X = v1.X;

            //Multiplying the 'y' values of the vector by the scalar
            v2.Y = v1.Y;

            //Returning the new vector
            return v2;
        }
    }
}
