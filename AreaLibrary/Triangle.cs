namespace AreaLibrary
{
    public class Triangle : IFigure
    {
        double SideA { get; set; }
        double SideB { get; set; }
        double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetArea()
        {
            var s = 0.5 * (SideA + SideB + SideC);
            var area = Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            return area;
        }

        public void RightTriangle()
        {
            if (SideA * SideA + SideB * SideB == SideC * SideC)
                Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}
