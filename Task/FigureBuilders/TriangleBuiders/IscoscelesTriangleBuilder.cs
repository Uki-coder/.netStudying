using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;
using Task.FigureBuilders;

internal class IscoscelesTriangleBuilder : TriangleBuilder
{
	public IscoscelesTriangleBuilder()
	{
	}

    public override Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
    {
        double distance12 = apex1.Distance(apex2);
        double distance13 = apex1.Distance(apex3);
        double distance23 = apex2.Distance(apex3);

        if ((Math.Abs(distance12 - distance13) <= double.Epsilon))
        {
            return new IscoscelesTriangle(apex1, apex2, apex3, border, fill);
        }
    }
}
