using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    internal class IscoscelesTriangle : Triangle
    {
        public IscoscelesTriangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
            Name = "iscosceles triangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            Area = 0.5 * Apex2.Distance(Apex3) * Math.Sqrt(Apex1.Distance(Apex2) * Apex1.Distance(Apex2) - 0.25 * Apex2.Distance(Apex3) * Apex2.Distance(Apex3));
            return Area;
        }
    }
}
