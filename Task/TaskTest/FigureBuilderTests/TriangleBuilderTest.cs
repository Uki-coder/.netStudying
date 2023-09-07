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

            List<Point> listP = new List<Point>();

            listP.Add(new Point(0, 0));
            listP.Add(new Point(2, 2 * Math.Sqrt(3)));
            listP.Add(new Point(4, 0));

            Figure equaliteralTriangle = builder.Build(listP, 0,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));

            Assert.IsTrue(equaliteralTriangle is EqualiteralTriangle); 
            listP[0] = new Point(0, 0);
            listP[1] = new Point(6, 20);
            listP[2] = new Point(12, 0);

            Figure iscoscelesTriangle = builder.Build(listP, 0,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(iscoscelesTriangle is IscoscelesTriangle);

            listP[0] = new Point(0, 0);
            listP[1] = new Point(3, 0);
            listP[2] = new Point(0, 4);

            Figure rightTriangle0 = builder.Build(listP, 0,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(rightTriangle0 is RightTriangle);

            listP[0] = new Point(1.8, 2.4);
            listP[1] = new Point(0, 0);
            listP[2] = new Point(5, 0);

            Figure rightTriangle1 = builder.Build(listP, 0,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(rightTriangle1 is RightTriangle);

            listP[0] = new Point(0, 0);
            listP[1] = new Point(4, 4);
            listP[2] = new Point(11, 0);

            Figure arbitraryTriangle = builder.Build(listP, 0,
                new Fill(new Color("TRANSPARENT", 0), 0),
                new Border(new Color("TRANSPARENT", 0), 0));
            Assert.IsTrue(arbitraryTriangle is ArbitraryTriangle);
        }
    }
}
