using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype
{
    public static class JoystickHelper
    {
        public static double GetAngleFromXYCoordinates(int x, int y)
        {
            double radians = Math.Atan2(y, x);
            double angle = radians * (180 / Math.PI);

            return angle;
        }

        public static double GetMagnitudeFromXYCoordinate(int x, int y)
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }
    }
}
