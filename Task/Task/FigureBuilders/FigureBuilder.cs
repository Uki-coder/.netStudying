using Task.Figures;
using Task.Figures.ColorProperties;

public abstract class FigureBuilder
{
    /// <summary>
    /// Next builder in figure builder chain
    /// </summary>
    protected FigureBuilder NextBuilder { set; get; }

    /// <summary>
    /// Constructor of abstract builder
    /// </summary>
    /// <param name="nextBuilder"></param>
    public FigureBuilder(FigureBuilder nextBuilder)
	{
        NextBuilder = nextBuilder;
	}

    /// <summary>
    /// Builds next figure in chain
    /// </summary>
    /// <param name="pointList"></param>
    /// <param name="radius"></param>
    /// <param name="fill"></param>
    /// <param name="border"></param>
    /// <returns></returns>
    public abstract Figure Build(List<Point> pointList, double radius, Fill fill, Border border); // ask about radius

}
