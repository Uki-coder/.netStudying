using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.FigureBuilders;

namespace TaskTest.FigureBuilderTests
{
    [TestClass]
    public class FigureBuilderTest
    {
        [TestMethod]
        public void CircleBuildTests()
        {
            FigureBuilder builder = new RectangleBuilder(new CircleBuilder(
                new EqualiteralTriangleBuilder(new IscoscelesTriangleBuilder(
                    new RightTriangelBuider(new ArbitraryTriangleBuilder(null))))));

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));

            Figure circle = builder.Build(points, 15,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));

            Assert.IsTrue(circle is Circle);

        }

        [TestMethod]
        public void RectangleBuildTest()
        {
            FigureBuilder builder = new RectangleBuilder(new CircleBuilder(
                new EqualiteralTriangleBuilder(new IscoscelesTriangleBuilder(
                    new RightTriangelBuider(new ArbitraryTriangleBuilder(null))))));

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(5, 1));

            Figure rectangle = builder.Build(points, 15,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));

            Assert.IsTrue(rectangle is Rectangle);
        }

        [TestMethod]
        public void TriangleBuildTest()
        {
            FigureBuilder builder = new RectangleBuilder(new CircleBuilder(
                new EqualiteralTriangleBuilder(new IscoscelesTriangleBuilder(
                    new RightTriangelBuider(new ArbitraryTriangleBuilder(null))))));

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(5, 1));
            points.Add(new Point(0, -2));

            Figure triangle = builder.Build(points, 15,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));

            Assert.IsTrue(triangle is Triangle);
        }

        [TestMethod]
        public void ExceptionAmoutOfPointsTest()
        {
            FigureBuilder builder = new RectangleBuilder(new CircleBuilder(
                new EqualiteralTriangleBuilder(new IscoscelesTriangleBuilder(
                    new RightTriangelBuider(new ArbitraryTriangleBuilder(null))))));

            List<Point> points = new List<Point>();
            points.Add(new Point(0, 0));
            points.Add(new Point(5, 1));
            points.Add(new Point(0, -2));
            points.Add(new Point(56, 32));

            Assert.ThrowsException<ArgumentException>(() => builder.Build(points, 15,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0)));
        }
    }
}
