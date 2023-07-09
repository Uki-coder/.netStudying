using Task.Figures;
using Task.Figures.ColorProperties;
using Task.Interfaces;

namespace Task.Containers;

internal class FigureContainer : IMovable
{
    //ask about Container realization
    public List<Figure> FigureList { get; set; }
    
    public FigureContainer()
    {
        FigureList = new List<Figure>();
    }

    public FigureContainer(int amount)
    {
        FigureList = new List<Figure>(amount);
    }

    public void MoveTo(Point destination) // ask about realization
    {
        for (int i = 0; i < FigureList.Count; i++) 
        {
            FigureList[i].MoveTo(destination);
        }
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
