using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace TaskTest.FiguresTests.TriangleTests
{
    [TestClass]
    public class EqualiteralTriangleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            EqualiteralTriangle triangle = new EqualiteralTriangle(
                new Point(0, 0), new Point(2, 2 * Math.Sqrt(3)), new Point(4, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(triangle.GetArea(), 4 * Math.Sqrt(3));
            Assert.AreEqual(triangle.Area, 4 * Math.Sqrt(3));
        }
    }
}
