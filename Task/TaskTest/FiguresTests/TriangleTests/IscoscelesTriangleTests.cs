using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace TaskTest.FiguresTests.TriangleTests
{
    [TestClass]
    public class IscoscelesTriangleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            IscoscelesTriangle triangle = new IscoscelesTriangle(
                new Point(0, 0), new Point(6, 20), new Point(12, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(triangle.GetArea(), 120);
            Assert.AreEqual(triangle.Area, 120);
        }
    }
}
