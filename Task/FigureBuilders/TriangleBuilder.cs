using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;

namespace Task.FigureBuilders
{
    internal class TriangleBuilder
    {
        public TriangleBuilder() { }

        public Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            if (apex1.Distance(apex2) - apex1.Distance(apex3) <= double.Epsilon &&
                apex2.Distance(apex3) - apex1.Distance(apex2) <= double.Epsilon)
            {
                return new EqualiteralTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (apex1.Distance(apex2) * apex1.Distance(apex2) + apex1.Distance(apex3) * apex1.Distance(apex3) - apex2.Distance(apex3) * apex2.Distance(apex3) <= double.Epsilon)
            {
                return new RightTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (apex2.Distance(apex1) * apex2.Distance(apex1) + apex2.Distance(apex3) * apex2.Distance(apex3) - apex1.Distance(apex3) * apex1.Distance(apex3) <= double.Epsilon)
            {
                return new RightTriangle(apex2, apex1, apex3, border, fill);
            }

            else if (apex3.Distance(apex2) * apex3.Distance(apex2) + apex3.Distance(apex1) * apex3.Distance(apex1) - apex2.Distance(apex1) * apex2.Distance(apex1) <= double.Epsilon)
            {
                return new RightTriangle(apex3, apex1, apex3, border, fill);
            }

            else if (apex1.Distance(apex2) - apex1.Distance(apex3) <= double.Epsilon)
            {
                return new IscoscelesTriangle(apex1, apex2, apex3, border, fill);
            }

            else if (apex2.Distance(apex1) - apex2.Distance(apex3) <= double.Epsilon)
            {
                return new IscoscelesTriangle(apex2, apex1, apex3, border, fill);
            }

            else if (apex3.Distance(apex2) - apex3.Distance(apex1) <= double.Epsilon)
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
