using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype
{
    public class DriveTrain
    {
        private readonly List<Wheel> Wheels;

        public DriveTrain() : this (new List<Wheel>())
        {
        }

        public DriveTrain(List<Wheel> wheels)
        {
            this.Wheels = wheels;
        }

        public int WheelCount => Wheels.Count;

        public void CalcualteMovement(int direction, int speed, int rotation)
        {

        }

    }
}
