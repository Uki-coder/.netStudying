using Task.Figures;
using Task.Figures.ColorProperties;
using Task.FigureBuilders;

public class CircleBuilder : FigureBuilder
{
    public CircleBuilder(FigureBuilder nextBuilder) : base(nextBuilder)
    {
        NextBuilder = nextBuilder;
    }

    public override Figure Build(List<Point> pointList, double radius, Fill fill, Border border)
    {
        if (pointList.Count == 1) return new Circle(pointList[0], radius, border, fill);
        else return NextBuilder?.Build(pointList, radius, fill, border);
    }
}