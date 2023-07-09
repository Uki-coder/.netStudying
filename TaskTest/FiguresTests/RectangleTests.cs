using Task.Figures;
using Task.Figures.ColorProperties;

namespace TaskTest.FiguresTests
{
    [TestClass]
    //ask about test comments
    public class RectangleTests
    {
        [TestMethod]
        public void MoveHorizontally()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            rectangle.MoveHorizontally(50);
            Assert.AreEqual(rectangle.LeftPoint.XCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.XCoordinate, 110);
        }

        [TestMethod]
        public void MoveVerticallyTest()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            rectangle.MoveVertically(50);
            Assert.AreEqual(rectangle.LeftPoint.YCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.YCoordinate, 80);
        }

        [TestMethod]
        public void ShiftTest()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            rectangle.Shift(50, 50);
            Assert.AreEqual(rectangle.LeftPoint.YCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.YCoordinate, 80);

            Assert.AreEqual(rectangle.LeftPoint.XCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.XCoordinate, 110);
        }

        [TestMethod]
        public void MoveToTest()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));
            Point destination = new Point(50, 50);

            rectangle.MoveTo(destination);
            Assert.AreEqual(rectangle.LeftPoint.XCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.XCoordinate, 110);

            Assert.AreEqual(rectangle.LeftPoint.YCoordinate, 50);
            Assert.AreEqual(rectangle.RightPoint.YCoordinate, 80);
        }

        [TestMethod]
        public void StretchTest()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            rectangle.Stretch(1.5);
            Assert.AreEqual(rectangle.LeftPoint.XCoordinate, 0);
            Assert.AreEqual(rectangle.RightPoint.XCoordinate, 90);

            Assert.AreEqual(rectangle.LeftPoint.YCoordinate, 0);
            Assert.AreEqual(rectangle.RightPoint.YCoordinate, 45);

            rectangle.Stretch(0.5);
            Assert.AreEqual(rectangle.LeftPoint.XCoordinate, 0);
            Assert.AreEqual(rectangle.RightPoint.XCoordinate, 45);

            Assert.AreEqual(rectangle.LeftPoint.YCoordinate, 0);
            Assert.AreEqual(rectangle.RightPoint.YCoordinate, 22.5);

            Assert.ThrowsException<ArgumentException>(() => rectangle.Stretch(0));
            Assert.ThrowsException<ArgumentException>(() => rectangle.Stretch(-1));
        }

        [TestMethod]
        public void GetAreaTest()
        {
            Rectangle rectangle = new Rectangle(new Point(0, 0), new Point(60, 30),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(rectangle.GetArea(), 1800);
            Assert.AreEqual(rectangle.Area, 1800);
        }
    }
}
