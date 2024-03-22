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
            const double radius_shara = 5;
            const double radius_okrujnosti = 60;
            const double height = 5;
            const double expected = 5497.79;
            var area = MathLib.CalculateSphereSectorSurfaceArea(radius_shara, radius_okrujnosti, height);
            Assert.AreEqual(expected, area, 0.01);
        }
       [Test]
        public void Test21()
        {
            const double radius_shara = -6;
            const double radius_okrujnosti = 60;
            const double height = 5;
            const double expected = 7916.81;
            Assert.Throws<Exception>(() => MathLib.CalculateSphereSectorSurfaceArea(radius_shara, radius_okrujnosti, height));
        }

    }
}