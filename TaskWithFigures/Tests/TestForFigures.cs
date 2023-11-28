using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWithFigures.Figures;

namespace TaskWithFigures.Tests
{
    /// <summary>
    /// Класс методов для тестов
    /// </summary>
    public class TestForFigures
    {
        /// <summary>
        /// Метод для теста прямоугольников
        /// </summary>
        public static void TestForRectangleFigure()
        {
            RectangleFigure rectangle = new RectangleFigure(10,5);

            Console.WriteLine($"P = {rectangle.GetPerimeter()}, S = {rectangle.GetArea()}");
        }

        /// <summary>
        /// Метод для теста окружностей
        /// </summary>
        public static void TestForCircleFigure()
        {
            CircleFigure cirle = new CircleFigure(6);

            Console.WriteLine($"P = {cirle.GetPerimeter()}, S = {cirle.GetArea()}");
        }
        /// <summary>
        /// Метод для теста треугольников
        /// </summary>
        public static void TestForTriangleFigure()
        {
            TriangleFigure triangle = new TriangleFigure(15, 8, 17);

            Console.WriteLine($"P = {triangle.GetPerimeter()}, S = {triangle.GetArea()}");
        }
        /// <summary>
        /// Метод для теста всех фигур
        /// </summary>
        public static void TestForAllFigures()
        {
            RectangleFigure rectangle = new RectangleFigure(8, 12);
            CircleFigure cirle = new CircleFigure(8);
            TriangleFigure triangle = new TriangleFigure(12, 13, 5);

            var figuresList = new List<IFigure>();
            figuresList.Add(rectangle);
            figuresList.Add(cirle);
            figuresList.Add(triangle);

            string result = String.Empty;

            foreach(var figure in figuresList)             
            {
                result += $"P = {figure.GetPerimeter()}, S = {figure.GetArea()}\n";
            }

            Console.WriteLine(result);
        }
        /// <summary>
        /// Метод для теста на прямоугольность треугольника
        /// </summary>
        public static void TestForRectangularTriangle()
        {
            TriangleFigure triangle = new TriangleFigure(7, 25, 24);

            Console.WriteLine($"IsRectangular = {triangle.IsRectangular()}");
        }
        /// <summary>
        /// Метод для проверки фигуры во время выполнения программы
        /// </summary>
        /// <param name="figureType">Ввод пользователя</param>
        public static void TestChoosingFigureInRunTime(string figureType)
        {
            //IFigure figure = null;
            switch(figureType.ToLower())
            {
                case "rectangle":
                    //figure = new RectangleFigure(5, 8);
                    Console.WriteLine("Is rectangle");
                    break;
                case "circle":
                    //figure = new CircleFigure(6);
                    Console.WriteLine("Is circle");
                    break;
                case "triangle":
                    //figure = new TriangleFigure(3, 4, 5);
                    Console.WriteLine("Is triangle");
                    break;
                default:
                    //figure = new RectangleFigure(4, 4);
                    Console.WriteLine("There is no such figure");
                    break;
            }


        }
    }
}
