using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;

namespace Task.FigureBuilders
{
    internal static class TriangleBuilder
    { 
        public static Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            double distance12 = apex1.Distance(apex2);
            double distance13 = apex1.Distance(apex3);
            double distance23 = apex2.Distance(apex3);

            if (Math.Abs(distance12 - distance13) <= double.Epsilon &&
                Math.Abs(distance23 - distance12) <= double.Epsilon)
            {
                return new EqualiteralTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (Math.Abs(distance12 * distance12 + distance13 * distance13 - distance23 * distance23) <= double.Epsilon)
            {
                return new RightTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (Math.Abs(distance12 * distance12 + distance23 * distance23 - distance13 * distance13) <= double.Epsilon)
            {
                return new RightTriangle(apex2, apex1, apex3, border, fill);
            }

            else if (Math.Abs(distance23 * distance23 + distance13 * distance13 - distance12 * distance12) <= double.Epsilon)
            {
                return new RightTriangle(apex3, apex1, apex3, border, fill);
            }

            else if (Math.Abs(distance12 - distance13) <= double.Epsilon)
            {
                return new IscoscelesTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (Math.Abs(distance12 - distance23) <= double.Epsilon)
            {
                return new IscoscelesTriangle(apex2, apex1, apex3, border, fill);
            }

            else if (Math.Abs(distance23 - distance13) <= double.Epsilon)
            {
                return new IscoscelesTriangle(apex3, apex2, apex1, border, fill);
            }

            else
            {
                return new ArbitraryTriangle(apex1, apex2, apex3, border, fill);
            }
        }
    }
}
