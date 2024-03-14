using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public class MathLib1
    {
        public static double CalculateSphereSectorSurfaceArea(double radius, double angleInDegrees)
        {
            
                if (radius <= 0 || angleInDegrees <= 0)
                {
                    throw new Exception();
                }

                double angleInRadians = angleInDegrees * Math.PI / 180;
                double S = 2 * Math.PI * radius * radius * (1 - Math.Cos(angleInRadians));
                return S;
            
            

        }



    }
}
