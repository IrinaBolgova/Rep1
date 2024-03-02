using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_Lab3.Library
{
    internal class Class2
    {
        static void Main()
        {
            double r = 5; // радиус сферы
            double h = 3; // высота сегмента

            double l = Math.Sqrt(h * (2 * r - h)); // длина дуги сегмента
            double S = 2 * Math.PI * r * h; // боковая площадь
            double Sb = Math.PI * Math.Pow(r, 2); // площадь основания
            double St = S + Sb; // полная площадь сферического сегмента

            Console.WriteLine("Площадь поверхности сферического сегмента: " + St);
        }
    }

}
