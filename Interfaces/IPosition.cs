using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IPosition
    {
        //Properties
        double X
        {
            get;
            set;
        }

        double Y
        {
            get;
            set;
        }

        //-------------------------------------------------
        //                  Methods
        //-------------------------------------------------

        //Distance to this coordinate from another coordinate
        double DistanceTo(IPosition position);

        //Moves the object to a new point
        void MoveTo(double x, double y);

        //Increases or decreases the X and/or Y coordinate
        void MoveBy(double xOffset, double yOffset);
    }
}
