using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;
using Task.FigureBuilders;

/// <summary>
/// Concrete builder of arbitary triangle in triangle builder chain
/// </summary>
public class ArbitraryTriangleBuilder : TriangleBuilder
{
    /// <summary>
    /// Create arbitary triangle builder
    /// </summary>
    /// <param name="nextBuilder">Given next triangle builder in chain</param>
    public ArbitraryTriangleBuilder(TriangleBuilder nextBuilder) : base(nextBuilder)
	{
        NextBuilder = nextBuilder;
    }

    /// <summary>
    /// Returns arbitary triangle based on given params 
    /// </summary>
    /// <param name="apex1">Gives first apex its position and properties</param>
    /// <param name="apex2">Gives second apex its position and properties</param>
    /// <param name="apex3">Gives third apex its position and properties</param>
    /// <param name="border">Gives border its properties</param>
    /// <param name="fill">Gives fill its properties</param>
    /// <returns></returns>
    public override Figure Build(List<Point> pointList, double radius, Fill fill, Border border)
    {
        return new ArbitraryTriangle(pointList[0], pointList[1], pointList[2], border, fill);
    }
}
