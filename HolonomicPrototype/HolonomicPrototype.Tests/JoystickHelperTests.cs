using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace HolonomicPrototype.Tests
{
    [TestClass]
    public class JoystickHelperTests
    {
        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(0,90,90)]
        [DataRow(90, 90, 45)]
        [DataRow(-90,-90,-135)]
        [DataRow(0,-90,-90)]
        [DataRow(180, 0, 0)]
        [DataRow(0,180,90)]
        public void GetDirection_FromJoyStickXYCoordinates(int x, int y, double expected)
        {
            double actual = JoystickHelper.GetAngleFromXYCoordinates(x, y);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod]
        [DataRow(0,0,0)]
        [DataRow(0,90,90)]
        [DataRow(90,90,127.2792)]
        [DataRow(-90,-90, 127.2792)]
        [DataRow(0,-90,90)]
        [DataRow(180,0,180)]
        [DataRow(0,180,180)]
        public void GetMagnitude_FromJoyStickXYCoordinates(int x, int y, double expected)
        {
            double actual = JoystickHelper.GetMagnitudeFromXYCoordinate(x, y);

            const double delta = 0.0001f;
            Assert.AreEqual(expected, actual, delta);
        }
    }
}
