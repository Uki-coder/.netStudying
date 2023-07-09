using Task.Figures.ColorProperties;
using Task.Figures.Triangle;
using Task.Figures;

namespace Task.FigureBuilders
{

    /// <summary>
    /// Abstract builder of triangles
    /// </summary>
    public abstract class TriangleBuilder
    {
        /// <summary>
        /// Next builder in triangle builder chain
        /// </summary>
        protected TriangleBuilder NextBuilder {set; get; }

        /// <summary>
        /// Creates abstract triangle builder
        /// </summary>
        /// <param name="nextBuilder">Given next triangle builder in chain</param>
        public TriangleBuilder(TriangleBuilder nextBuilder)
        {
            NextBuilder = nextBuilder;
        }

        /// <summary>
        /// Returns abstract triangle based on given params 
        /// </summary>
        /// <param name="apex1">Gives first apex its position and properties</param>
        /// <param name="apex2">Gives second apex its position and properties</param>
        /// <param name="apex3">Gives third apex its position and properties</param>
        /// <param name="border">Gives border its properties</param>
        /// <param name="fill">Gives fill its properties</param>
        /// <returns></returns>
        public abstract Triangle Build(Point apex1, Point apex2, Point apex3, Border border, Fill fill);
    }
}
