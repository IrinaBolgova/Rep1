using System;
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
            const int radius = -6;
            const int angleInDegrees = 60;
            const double expected = 113.09;

            var area = MathLib.CalculateSphereSectorSurfaceArea(radius, angleInDegrees);
            Assert.AreEqual(expected, area, 0.01);
            TestMethod();
        }
        public void TestMethod()
        {
            // Организация
            var exceptionType = typeof(ArgumentException);

            // Действие
            var exception = Assert.Throws<ArgumentException>(() => ThrowException());

            // Утверждение
            Assert.AreEqual(exceptionType, exception.GetType());
        }
        private void ThrowException()
        {
            throw new ArgumentException();
        }
    }
}
