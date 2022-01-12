using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaConsoleApp
{
    internal class Circle
    {
        public static double GetArea(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}
