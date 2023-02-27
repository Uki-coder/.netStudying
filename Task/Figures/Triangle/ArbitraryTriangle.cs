using Task.Figures.ColorProperties;

namespace Task.Figures.Triangle
{
    internal class ArbitraryTriangle : Triangle
    {
        public ArbitraryTriangle(Point apex1, Point apex2, Point apex3, Border border, Fill fill)
        {
            Apex1 = apex1;
            Apex2 = apex2;
            Apex3 = apex3;
            Name = "arbitrary triangle";
            FigureBorder = border;
            FigureFill = fill;
        }

        public override double GetArea()
        {
            double halPer = 0.5 * (Apex1.Distance(Apex2) + Apex2.Distance(Apex3) + Apex3.Distance(Apex1));
            Area = Math.Sqrt(halPer * (halPer - Apex1.Distance(Apex2) * (halPer - Apex2.Distance(Apex3) * (halPer - Apex3.Distance(Apex1)))));
            return Area;
        }
    }
}
