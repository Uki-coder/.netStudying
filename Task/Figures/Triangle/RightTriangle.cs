using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    internal class RightTriangle : Triangle
    {
        public RightTriangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
            Name = "right triangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            Area = Apex1.Distance(Apex2) * Apex1.Distance(Apex3) * 0.5;
            return Area;
        }
    }
}
