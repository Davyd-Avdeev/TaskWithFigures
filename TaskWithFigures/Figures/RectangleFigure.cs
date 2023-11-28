

namespace TaskWithFigures.Figures
{
    class RectangleFigure : IFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        
        public RectangleFigure(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }


        public double GetPerimeter()
        {
            double perimeter = SideA * 2 + SideB * 2; 
            return perimeter;
        }

        public double GetArea()
        {
            double area = SideA * SideB;
            return area;
        }

    }
}
