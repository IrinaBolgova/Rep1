using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    public class MathLib
    {
        public static double CalculateSphereSectorSurfaceArea(double radius_shara, double radius_okrujnosti, double height)
        {
            //try
           // {
                if (radius_shara <= 0)
                {
                    throw new Exception("Радиус должен быть задан положительным числом");
                }
                if (radius_okrujnosti <= 0)
                {
                    throw new Exception("Угол должен быть задан положительным числом");
                }

                //double radius_okrujnostia = radius_okrujnosti * Math.PI / 180;
                double S = Math.PI * radius_shara * radius_shara * (2 * height + radius_okrujnosti);
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
