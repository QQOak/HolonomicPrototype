using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype
{
    public class Wheel
    {
        public Wheel(int driveAngle, int freeRunningAngle, int diameter) : this (driveAngle, freeRunningAngle, diameter, 0)
        {
        }

        public Wheel(int driveAngle, int freeRunningAngle, int diameter, int distanceFromCentre)
        {
            DriveAngle = driveAngle;
            FreeRunningAngle = freeRunningAngle;
            Diameter = diameter;
            DistanceFromCentre = distanceFromCentre;
        }

        public int DriveAngle { get; set; }

        public int FreeRunningAngle { get; set; }

        public int Diameter { get; set; }

        public int DistanceFromCentre { get; set; } = 0;
    }
}
