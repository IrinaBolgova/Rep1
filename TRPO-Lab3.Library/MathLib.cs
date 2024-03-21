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
            //try
           // {
                if (radius <= 0)
                {
                    throw new Exception("Радиус должен быть задан положительным числом");
                }
                if (angleInDegrees <= 0)
                {
                    throw new Exception("Угол должен быть задан положительным числом");
                }

                double angleInRadians = angleInDegrees * Math.PI / 180;
                double S = 2 * Math.PI * radius * radius * (1 - Math.Cos(angleInRadians));
                return S;
            ////}
           // catch (Exception ex)
            //{
               // Console.WriteLine("произошло исключение: " + ex.Message);
              //  Console.WriteLine("нажмите любую клавишу для выхода...");
              //  Console.ReadKey(); 
              //  return -1;
            //}

        }
        


    }
}
