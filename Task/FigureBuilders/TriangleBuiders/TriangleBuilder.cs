using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;

namespace Task.FigureBuilders
{
    internal abstract class TriangleBuilder
    {   
        public TriangleBuilder()
        {
        }
        public abstract Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill);
    }
}
