using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Interfaces;
using Task.Figures.Triangle;

namespace Task.Containers;
/// <summary>
/// Сontainer for figure objects including list of figures and able for IMovable interface
/// </summary>
public class FigureContainer : IMovable
{
    /// <summary>
    /// List of figures
    /// </summary>
    public List<Figure> FigureList { get; private set; }

    public FigureContainer()
    {
        FigureList = new List<Figure>();
    }

    public FigureContainer(int amount)
    {
        FigureList = new List<Figure>(amount);
    }

    public void MoveTo(Point destination)
    {
        for (int i = 1; i < FigureList.Count; i++)
            FigureList[i].Shift(
                destination.XCoordinate - FigureList[0].MainPoint.XCoordinate,
                destination.YCoordinate - FigureList[0].MainPoint.YCoordinate);

        FigureList[0].MoveTo(destination);
    }

    public void Shift(double x, double y)
    {
        for (int i = 0; i < FigureList.Count; i++)
        {
            FigureList[i].Shift(x, y);
        }
    }

    public void MoveVertically(double y)
    {
        for (int i = 0; i < FigureList.Count; i++)
        {
            FigureList[i].MoveVertically(y);
        }
    }

    public void MoveHorizontally(double x)
    {
        for (int i = 0; i < FigureList.Count; i++)
        {
            FigureList[i].MoveHorizontally(x);
        }
    }
}
