using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.FigureBuilders;
using Task.Containers;
using NuGet.Frameworks;

namespace TaskTest.ContainersTests
{
    [TestClass]
    public class FigureContainerTests
    {
        [TestMethod]
        public void MoveToTest()
        {
            FigureContainer container = new FigureContainer();
            
            container.FigureList.Add(new Circle(new Point(0,0), 15,
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));

            container.FigureList.Add(new Rectangle(new Point(5,4), new Point(10,6),
                new Border(new Color("TRANSPARENT", 0), 0),
                new Fill(new Color("TRANSPARENT", 0), 0)));

            container.MoveTo(new Point(2, 2));

            Assert.IsTrue(Math.Abs(container.FigureList[0].MainPoint.XCoordinate - 2) <= double.Epsilon &&
                Math.Abs(container.FigureList[0].MainPoint.YCoordinate - 2) <= double.Epsilon &&
                Math.Abs(container.FigureList[1].MainPoint.XCoordinate - 7) <= double.Epsilon &&
                Math.Abs(container.FigureList[1].MainPoint.YCoordinate - 6) <= double.Epsilon);

        }
    }
}
