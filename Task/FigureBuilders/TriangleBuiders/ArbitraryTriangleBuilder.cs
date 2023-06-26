using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;
using Task.FigureBuilders;

internal class ArbitraryTriangleBuilder : TriangleBuilder
{
	public ArbitraryTriangleBuilder()
	{
        
    }

    public override Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
    {
        return new ArbitraryTriangle(apex1, apex2, apex3, border, fill);
    }
}
