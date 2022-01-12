using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaConsoleApp
{
    internal class Triangle
    {
        public static double GetArea(double sideA, double sideB, double sideC)
        {
            var s = 0.5 * (sideA + sideB + sideC);
            var area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return area;
        }

        public static void RightTriangle(double sideA, double sideB, double sideC)
        {
            if (sideA * sideA + sideB * sideB == sideC * sideC)
                Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}
