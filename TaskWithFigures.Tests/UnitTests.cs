namespace TaskWithFigures.Tests
{
    public class Tests
    {
        private const string ExpectedForRectangleTest = "P = 30, S = 50";
        private const string ExpectedForCircleTest = "P = 37,692, S = 113,076";
        private const string ExpectedForTriangleTest = "P = 40, S = 60";
        private const string ExpectedForAllFigures = "P = 40, S = 96\nP = 50,256, S = 201,024\nP = 30, S = 30";
        private const string ExpectedForRectangularTriangle = "IsRectangular = True";

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void TestForRectangle()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TaskWithFigures.Tests.TestForFigures.TestForRectangleFigure();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForRectangleTest, result);
            }
        }

        [Test]
        public void TestForCircle()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TaskWithFigures.Tests.TestForFigures.TestForCircleFigure();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForCircleTest, result);
            }
        }

        [Test]
        public void TestForTriangle()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TaskWithFigures.Tests.TestForFigures.TestForTriangleFigure();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForTriangleTest, result);
            }
        }

        [Test]
        public void TestForAllFigures()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TaskWithFigures.Tests.TestForFigures.TestForAllFigures();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForAllFigures, result);
            }
        }
        [Test]
        public void TestForRectangularTriangle()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                TaskWithFigures.Tests.TestForFigures.TestForRectangularTriangle();

                var result = sw.ToString().Trim();
                Assert.AreEqual(ExpectedForRectangularTriangle, result);
            }
        }
    }
}