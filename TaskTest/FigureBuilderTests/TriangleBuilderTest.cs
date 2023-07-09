using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.FigureBuilders;

namespace TaskTest.FigureBuilderTests
{
    [TestClass]
    public class TriangleBuilderTest
    {
        [TestMethod]
        public void BuilderTest()
        {
            TriangleBuilder builder = new EqualiteralTriangleBuilder(
                new IscoscelesTriangleBuilder(new RightTriangelBuider(
                    new ArbitraryTriangleBuilder(null))));

            Triangle equaliteralTriangle = builder.Build(
                new Point(0, 0), new Point(2, 2 * Math.Sqrt(3)), new Point(4, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.IsTrue(equaliteralTriangle is EqualiteralTriangle); //ask about double.Epsilon */

            Triangle iscoscelesTriangle = builder.Build(
                new Point(0, 0), new Point(6, 20), new Point(12, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(iscoscelesTriangle is IscoscelesTriangle);

            Triangle rightTriangle0 = builder.Build(
                new Point(0, 0), new Point(3, 0), new Point(0, 4),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(rightTriangle0 is RightTriangle);

            Triangle rightTriangle1 = builder.Build(
                new Point(1.8, 2.4), new Point(0, 0), new Point(5, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(rightTriangle1 is RightTriangle);

            Triangle arbitraryTriangle = builder.Build(
                new Point(0, 0), new Point(4, 4), new Point(11, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(arbitraryTriangle is ArbitraryTriangle);
        }
    }
}
