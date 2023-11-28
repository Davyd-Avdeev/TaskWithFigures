

using System.Reflection.Metadata;

namespace TaskWithFigures.Figures
{
    class TriangleFigure : IFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        public TriangleFigure(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double GetPerimeter()
        {
            double perimeter = SideA + SideB + SideC;
            return perimeter;
        }

        public double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            return area;
        }

        public bool IsRectangular()
        {

            if (SideC > SideA)
            {
                if (SideC > SideB)
                {
                    if (Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2))
                    {
                        return true;
                    }
                    //CMax
                }
                else
                {
                    if (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                    {
                        return true;
                    }
                    //Bmax
                }
            }
            else if (SideA > SideB)
            {
                if (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                {
                    return true;
                }
                //AMax
            }
            else 
            {
                if (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                {
                    return true;
                }
            }


            return false;
        }
    }
}
