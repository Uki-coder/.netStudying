using System.Collections.Generic;
using Task.Figures;
using Task.Figures.ColorProperties;
public class RectangleBuilder : FigureBuilder
{
    public RectangleBuilder(FigureBuilder nextBuilder) : base(nextBuilder)
    {
        NextBuilder = nextBuilder;
    }

    public override Figure Build(List<Point> pointList, double radius, Fill fill, Border border)
    {
        if (pointList.Count == 2) return new Rectangle(pointList[0], pointList[1], border, fill);
        else return NextBuilder?.Build(pointList, radius, fill, border);
    }
}

