

using System.Reflection.Metadata;

namespace TaskWithFigures.Figures
{
    class TriangleFigure : IFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="sideA">Первая сторона треугольника</param>
        /// <param name="sideB">Вторая сторона треугольника</param>
        /// <param name="sideC">Третья сторона треугольника</param>
        public TriangleFigure(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Реализация метода вычисления периметра
        /// </summary>
        /// <returns>Возврат периметра</returns>
        public double GetPerimeter()
        {
            double perimeter = SideA + SideB + SideC;
            return perimeter;
        }

        /// <summary>
        /// Реализация метода вычисления площади
        /// </summary>
        /// <returns>Возврат площади</returns>
        public double GetArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
            return area;
        }

        /// <summary>
        /// Метод проверки на прямоугольность
        /// </summary>
        /// <returns>Возврат результата типа bool</returns>
        public bool IsRectangular()
        {

            if (SideC > SideA)
            {
                if (SideC > SideB)
                {
                    //C Max
                    if (Math.Pow(SideC, 2) == Math.Pow(SideA, 2) + Math.Pow(SideB, 2))
                    {
                        return true;
                    }                    
                }
                else
                {
                    //B Max
                    if (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                    {
                        return true;
                    }                    
                }
            }
            else if (SideA > SideB)
            {
                //A Max
                if (Math.Pow(SideA, 2) == Math.Pow(SideB, 2) + Math.Pow(SideC, 2))
                {
                    return true;
                }
                
            }
            else 
            {
                //B Max
                if (Math.Pow(SideB, 2) == Math.Pow(SideA, 2) + Math.Pow(SideC, 2))
                {
                    return true;
                }
            }

            //Треугольник не прямоугольный

            return false;
        }
    }
}
