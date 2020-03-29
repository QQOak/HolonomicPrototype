using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype
{
    public class Wheel
    {
        public Wheel(int freeRunningAngle, int diameter)
        {
            FreeRunningAngle = freeRunningAngle;
            Diameter = diameter;
        }

        /// <summary>
        /// The angle on the wheels of the free spinning rollers.  90 for Omniwheels, 45 or 315 for meccanum
        /// </summary>
        public int FreeRunningAngle { get; set; }

        /// <summary>
        /// Diameter of the wheel
        /// </summary>
        public int Diameter { get; set; }
    }
}
