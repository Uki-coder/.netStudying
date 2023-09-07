using Task.Figures;

namespace TaskTest.FiguresTests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void MoveToTest()
        {
            Point point = new Point(42, 39);
            Point destination = new Point(22, 19);

            point.MoveTo(destination);
            Assert.AreEqual(point.XCoordinate, 22);
            Assert.AreEqual(point.YCoordinate, 19);

        }

        [TestMethod]
        public void MoveHorizontallyTest()
        {
            Point point = new Point(42, 39);
            point.MoveHorizontally(10);
            Assert.AreEqual(52, point.XCoordinate);
        }

        [TestMethod]
        public void MoveVerticallyTest()
        {
            Point point = new Point(42, 39);
            point.MoveVertically(10);
            Assert.AreEqual(49, point.YCoordinate);
        }

        [TestMethod]
        public void ShiftTest()
        {
            Point point = new Point(42, 39);
            point.Shift(-10, -10);
            Assert.AreEqual(point.XCoordinate, 32);
            Assert.AreEqual(point.YCoordinate, 29);
        }

        [TestMethod]
        public void DistanceTest()
        {
            Point point = new Point(0, 0);
            Point point1 = new Point(3, 4);

            Assert.AreEqual(point.Distance(point1), 5);
        }
    }
}