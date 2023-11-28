

namespace TaskWithFigures.Figures
{
    class RectangleFigure : IFigure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }

        /// <summary>
        /// Конструктор класс
        /// </summary>
        /// <param name="sideA">Первая сторона прямоугольника</param>
        /// <param name="sideB">Вторая сторона прямоугольника</param>
        public RectangleFigure(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        /// <summary>
        /// Реализация метода вычисления периметра
        /// </summary>
        /// <returns>Возврат периметра</returns>
        public double GetPerimeter()
        {
            double perimeter = SideA * 2 + SideB * 2; 
            return perimeter;
        }

        /// <summary>
        /// Реализация метода вычисления площади
        /// </summary>
        /// <returns>Возврат площади</returns>
        public double GetArea()
        {
            double area = SideA * SideB;
            return area;
        }

    }
}
