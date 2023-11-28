

namespace TaskWithFigures.Figures
{
    class CircleFigure : IFigure
    {

        private double Radius { get; set; }
        private const double P = 3.141;

        public CircleFigure(double radius)
        {
            Radius = radius;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * P * Radius;
            return perimeter;
        }

        public double GetArea()
        {
            double area = Radius * Radius * P;
            return area;
        }
    }
}
