

namespace TaskWithFigures.Figures
{
    class CircleFigure : IFigure
    {

        private double Radius { get; set; }
        private const double P = 3.141;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">Радиус окружности</param>
        public CircleFigure(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Реализация метода вычисления периметра
        /// </summary>
        /// <returns>Возврат периметра</returns>
        public double GetPerimeter()
        {
            double perimeter = 2 * P * Radius;
            return perimeter;
        }

        /// <summary>
        /// Реализация метода вычисления площади
        /// </summary>
        /// <returns>Возврат площади</returns>
        public double GetArea()
        {
            double area = Radius * Radius * P;
            return area;
        }
    }
}
