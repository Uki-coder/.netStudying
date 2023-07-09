using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;
using Task.FigureBuilders;

/// <summary>
/// Concrete builder of right triangle in triangle builder chain
/// </summary>
public class RightTriangelBuider : TriangleBuilder
{
    /// <summary>
    /// Creates right triangle builder
    /// </summary>
    /// <param name="nextBuilder">Given next triangle builder in chain</param>
    public RightTriangelBuider(TriangleBuilder nextBuilder) : base(nextBuilder)
	{
        NextBuilder = nextBuilder;
    }

    /// <summary>
    /// Returns right triangle based on given params 
    /// </summary>
    /// <param name="apex1">Gives first apex its position and properties</param>
    /// <param name="apex2">Gives second apex its position and properties</param>
    /// <param name="apex3">Gives third apex its position and properties</param>
    /// <param name="border">Gives border its properties</param>
    /// <param name="fill">Gives fill its properties</param>
    /// <returns></returns>
    public override Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
    {
        double distance12 = apex1.Distance(apex2);
        double distance13 = apex1.Distance(apex3);
        double distance23 = apex2.Distance(apex3);

        if (Math.Abs(distance12 * distance12 + distance13 * distance13 - distance23 * distance23) <= double.Epsilon ||
            Math.Abs(distance12 * distance12 + distance23 * distance23 - distance13 * distance13) <= double.Epsilon ||
            Math.Abs(distance23 * distance23 + distance13 * distance13 - distance12 * distance12) <= double.Epsilon)
            return new RightTriangle(apex2, apex1, apex3, border, fill);

        else return NextBuilder?.Build(apex1, apex2, apex3, border, fill);
    }
}
