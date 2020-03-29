using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype
{
    public class DriveWheel
    {
        public DriveWheel(int angle, Wheel Wheel)
        {
            this.Angle = angle;
            this.Wheel = Wheel;
        }

        /// <summary>
        /// Angle from directly forwards.  A standard configuration (going clockwise) for an x drive would be 315 , 225, 135, 45.
        /// </summary>
        public int Angle { get; }

        /// <summary>
        /// The wheel at this position
        /// </summary>
        public Wheel Wheel { get; }
    }
}
