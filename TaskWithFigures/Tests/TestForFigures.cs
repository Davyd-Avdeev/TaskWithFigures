using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskWithFigures.Figures;

namespace TaskWithFigures.Tests
{
    public class TestForFigures
    {
        public static void TestForRectangleFigure()
        {
            RectangleFigure rectangle = new RectangleFigure(10,5);

            Console.WriteLine($"P = {rectangle.GetPerimeter()}, S = {rectangle.GetArea()}");
        }

        public static void TestForCircleFigure()
        {
            CircleFigure cirle = new CircleFigure(6);

            Console.WriteLine($"P = {cirle.GetPerimeter()}, S = {cirle.GetArea()}");
        }

        public static void TestForTriangleFigure()
        {
            TriangleFigure triangle = new TriangleFigure(15, 8, 17);

            Console.WriteLine($"P = {triangle.GetPerimeter()}, S = {triangle.GetArea()}");
        }

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

        public static void TestForRectangularTriangle()
        {
            TriangleFigure triangle = new TriangleFigure(7, 25, 24);

            Console.WriteLine($"IsRectangular = {triangle.IsRectangular()}");
        }
    }
}
