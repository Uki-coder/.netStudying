using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace TaskTest.FiguresTests.TriangleTests
{
    [TestClass]
    public class RightTriangleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            RightTriangle triangle = new RightTriangle(
                new Point(1.8, 2.4), new Point(0, 0), new Point(5, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(triangle.GetArea(), 6);
            Assert.AreEqual(triangle.Area, 6);

            RightTriangle triangle1 = new RightTriangle(
                new Point(0, 0), new Point(3, 0), new Point(0, 4),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(triangle1.GetArea(), 6);
            Assert.AreEqual(triangle1.Area, 6);
        }
    }
}
