using NUnit.Framework;
using TRPO_Lab3.Library;
using System;

namespace TRPO_Lab3.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            const double radius = 5;
            const double angleInDegrees = 60;
            const double expected = 78.54;


            var area = MathLib.CalculateSphereSectorSurfaceArea(radius, angleInDegrees);
            Assert.AreEqual(expected, area, 0.01);
        }
       [Test]
        public void Test21()
        {
            const double radius = -6;
            const double angleInDegrees = 60;
            const double expected = 113.09;
            Assert.Throws<Exception>(() => MathLib1.CalculateSphereSectorSurfaceArea(radius, angleInDegrees));
        }

    }
}