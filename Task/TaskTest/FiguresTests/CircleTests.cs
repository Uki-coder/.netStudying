using Task.Figures;
using Task.Figures.ColorProperties;

namespace TaskTest.FiguresTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void StretchTest()
        {
            Circle circle = new Circle(new Point(0, 0), 15,
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            circle.Stretch(4);
            Assert.AreEqual(circle.Radius, 60);

            circle.Stretch(0.5);
            Assert.AreEqual(circle.Radius, 30);

            Assert.ThrowsException<ArgumentException>(() => circle.Stretch(0));
            Assert.ThrowsException<ArgumentException>(() => circle.Stretch(-1));
        }

        [TestMethod]
        public void GetAreaTest()
        {
            Circle circle = new Circle(new Point(0, 0), 15,
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0));

            Assert.AreEqual(circle.GetArea(), 225 * Math.PI);
        }
    }
}
