using Task.Figures;

namespace TaskTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MovePointTest()
        {
            Point point = new Point(42, 39);
            point.MoveHorizontally(10);
            Assert.AreEqual(52, point.XCoordinate);
        }
    }
}