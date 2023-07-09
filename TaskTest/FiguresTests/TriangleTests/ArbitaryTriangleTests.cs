using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;

namespace TaskTest.FiguresTests.TriangleTests
{
    //ask about IMovable test for all types of triangle
    //ask about test comments
    [TestClass]
    public class ArbitraryTriangleTests
    {
        [TestMethod]
        public void GetAreaTest()
        {
            ArbitraryTriangle triangle = new ArbitraryTriangle(
                new Point(0,0), new Point(3,4), new Point(9,0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(triangle.GetArea(), 18);
            Assert.AreEqual(triangle.Area, 18);
            //ask about double.Epsilon and current situation
            Assert.IsTrue(Math.Abs(triangle.Area - 18) <= double.Epsilon); //ask about double.Epsilon and current situation
        }

        [TestMethod]
        public void ConstructorException()
        {
            Assert.ThrowsException<ArgumentException>(() => new ArbitraryTriangle(
                new Point(0, 0), new Point(2,4), new Point(9, 18),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));



            Assert.ThrowsException<ArgumentException>(() => new ArbitraryTriangle(
                new Point(0, 0), new Point(0, 0), new Point(9, 18),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));

            Assert.ThrowsException<ArgumentException>(() => new ArbitraryTriangle(
                new Point(0, 0), new Point(2, 4), new Point(0, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));

            Assert.ThrowsException<ArgumentException>(() => new ArbitraryTriangle(
                new Point(0, 0), new Point(2, 4), new Point(0, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));
        }

        [TestMethod]
        public void ShiftTest()
        {
            ArbitraryTriangle triangle = new ArbitraryTriangle(
                new Point(0, 0), new Point(3, 4), new Point(9, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            triangle.Shift(20, 20);

            Assert.AreEqual(triangle.Apex1.XCoordinate, 20);
            Assert.AreEqual(triangle.Apex1.YCoordinate, 20);

            Assert.AreEqual(triangle.Apex2.XCoordinate, 23);
            Assert.AreEqual(triangle.Apex2.YCoordinate, 24);

            Assert.AreEqual(triangle.Apex3.XCoordinate, 29);
            Assert.AreEqual(triangle.Apex3.YCoordinate, 20);
        }

        [TestMethod]
        public void MoveHorizontallyTest()
        {
            ArbitraryTriangle triangle = new ArbitraryTriangle(
                new Point(0, 0), new Point(3, 4), new Point(9, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            triangle.MoveHorizontally(20);

            Assert.AreEqual(triangle.Apex1.XCoordinate, 20);
            Assert.AreEqual(triangle.Apex2.XCoordinate, 23);
            Assert.AreEqual(triangle.Apex3.XCoordinate, 29);
        }

        [TestMethod]
        public void MoveVerticallyTest()
        {
            ArbitraryTriangle triangle = new ArbitraryTriangle(
                new Point(0, 0), new Point(3, 4), new Point(9, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            triangle.MoveVertically(20);

            Assert.AreEqual(triangle.Apex1.YCoordinate, 20);
            Assert.AreEqual(triangle.Apex2.YCoordinate, 24);
            Assert.AreEqual(triangle.Apex3.YCoordinate, 20);
        }

        [TestMethod]
        public void MoveToTest()
        {
            ArbitraryTriangle triangle = new ArbitraryTriangle(
                new Point(0, 0), new Point(3, 4), new Point(9, 0),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Point destination = new Point(20, 20);

            triangle.MoveTo(destination);

            Assert.AreEqual(triangle.Apex1.XCoordinate, 20);
            Assert.AreEqual(triangle.Apex1.YCoordinate, 20);

            Assert.AreEqual(triangle.Apex2.XCoordinate, 23);
            Assert.AreEqual(triangle.Apex2.YCoordinate, 24);

            Assert.AreEqual(triangle.Apex3.XCoordinate, 29);
            Assert.AreEqual(triangle.Apex3.YCoordinate, 20);
        }
    }
}
