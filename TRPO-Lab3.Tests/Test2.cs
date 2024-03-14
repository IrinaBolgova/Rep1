
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TRPO_Lab3.Library;
using System;

namespace TRPO_Lab3.Tests
{
    public class Test2
    {
        [Test]
        public void Test21()
        {
            const double radius = -6;
            const double angleInDegrees = 60;
            //const double expected = 113.09;
            Assert.Throws<Exception>(() => MathLib.CalculateSphereSectorSurfaceArea(radius, angleInDegrees));
        }

    }
}
