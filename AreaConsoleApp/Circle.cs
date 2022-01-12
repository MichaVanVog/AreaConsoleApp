using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaConsoleApp
{
    internal class Circle: IFigure
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
