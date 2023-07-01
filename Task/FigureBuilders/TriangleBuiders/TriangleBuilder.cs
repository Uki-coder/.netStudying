using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;

namespace Task.FigureBuilders
{
    internal abstract class TriangleBuilder
    {
        protected TriangleBuilder NextBuilder {set; get; }
        public TriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;
        }
        public abstract Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill);
    }
}
