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
            const int radius = 5;
            const int angleInDegrees = 60;
            const double expected = 78.54;

            var area = MathLib.CalculateSphereSectorSurfaceArea(radius, angleInDegrees);
            Assert.AreEqual(expected, area, 0.01);
            TestMethod();
        }
        public void TestMethod()
        {
            // �����������
            var exceptionType = typeof(ArgumentException);

            // ��������
            var exception = Assert.Throws<ArgumentException>(() => ThrowException());

            // �����������
            Assert.AreEqual(exceptionType, exception.GetType());
        }
        private void ThrowException()
        {
            throw new ArgumentException();
        }
        
    }
}