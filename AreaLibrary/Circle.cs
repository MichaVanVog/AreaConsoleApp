namespace AreaLibrary
{
    public class Circle: IFigure
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
