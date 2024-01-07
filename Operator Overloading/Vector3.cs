using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Vector3
    {
        //Fields
        protected double x;
        protected double y;
        protected double z;



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

        //Z Property
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }



        //Constructors

        //Default Constructor
        public Vector3()
        {
            x = 0;
            y = 0;
            z = 0;
        }

        //Parameterized Constructor
        public Vector3(double exx, double why, double zee)
        {
            x = exx;
            y = why;
            z = zee;
        }



        //Methods

        //Override ToString
        public override string ToString()
        {
            return ("(" + x + ", " + y + ", " + z + ")");
        }



        //Operators

        //Vector + Vector   Operator
        public static Vector3 operator + (Vector3 v1, Vector3 v2)
        {
            //Create the brand new vector
            Vector3 v3 = new Vector3();

            //Adding the 'x' values of the two vectors
            v3.X = v1.X + v2.X;

            //Adding the 'y' values of the two vectors
            v3.Y = v1.Y + v2.Y;

            //Adding the 'z' values of the two vectors
            v3.Z = v1.Z + v2.Z;

            //Returning the new vector
            return v3;
        }

        //Vector - Vector   Operator
        public static Vector3 operator - (Vector3 v1, Vector3 v2)
        {
            //Create the brand new vector
            Vector3 v3 = new Vector3();

            //Subtracting the 'x' values of the two vectors
            v3.X = v1.X - v2.X;

            //Subtracting the 'y' values of the two vectors
            v3.Y = v1.Y - v2.Y;

            //Subtracting the 'z' values of the two vectors
            v3.Z = v1.Z - v2.Z;

            //Returning the new vector
            return v3;
        }

        //Vector * Scalar   Operator
        public static Vector3 operator * (Vector3 v1, int scalar)
        {
            //Create the brand new vector
            Vector3 v2 = new Vector3();

            //Multiplying the 'x' value of the vector by the scalar
            v2.X = v1.X * scalar;

            //Multiplying the 'y' value of the vector by the scalar
            v2.Y = v1.Y * scalar;

            //Multiplying the 'z' value of the vector by the scalar
            v2.Z = v1.Z * scalar;

            //Returning the new vector
            return v2;
        }

        //Vector / Scalar   Operator
        public static Vector3 operator / (Vector3 v1, int scalar)
        {
            //Create the brand new vector
            Vector3 v2 = new Vector3();

            //Dividing the 'x' value of the vector by the scalar
            v2.X = v1.X / scalar;

            //Dividing the 'y' value of the vector by the scalar
            v2.Y = v1.Y / scalar;

            //Dividing the 'z' value of the vector by the scalar
            v2.Z = v1.Z / scalar;

            //Returning the new vector
            return v2;
        }

        //Vector3 -> Vector2    Conversion Operator
        public static explicit operator Vector3 (Vector2 v1)
        {
            //Create the brand new vector
            Vector3 v2 = new Vector3();

            //Multiplying the 'x' values of the vector by the scalar
            v2.X = v1.X;

            //Multiplying the 'y' values of the vector by the scalar
            v2.Y = v1.Y;

            //Returning the new vector
            return v2;
        }
    }
}
