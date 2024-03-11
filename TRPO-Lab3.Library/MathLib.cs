using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public class MathLib
    {
        public static double CalculateSphereSectorSurfaceArea(double radius, double angleInDegrees)
        {
            // Переводим угол из градусов в радианы
            double angleInRadians = angleInDegrees * Math.PI / 180;

            // Рассчитываем площадь поверхности шарового сектора
            double surfaceArea = 2 * Math.PI * radius * radius * (1 - Math.Cos(angleInRadians));

            return surfaceArea;
        }


    }
}
