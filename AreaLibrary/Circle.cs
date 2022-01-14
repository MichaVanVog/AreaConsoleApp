namespace AreaLibrary
{
    public class Circle : IFigure
    {
        double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double GetArea()
        {
            var area = Math.Round(Math.PI * Math.Pow(Radius, 2), 4);
            return area;
        }
    }
}
