using Task.Figures.ColorProperties;
using Task.Interfaces;

namespace Task.Figures
{
    internal abstract class Figure : IMovable
    {

        public double Area { get; protected set; }
        public string Name { get; protected set; } //Type of figure: Circle, Recctangle, Triangle //ask: enum to string
        public Border FigureBorder { get; protected set; }
        public Fill FigureFill { get; protected set; }


        public Figure()
        {
            Name = string.Empty;
            FigureBorder = new Border(new Color("", 0), 0);
            FigureFill = new Fill(new Color("", 0), 0);
        }

        public abstract double GetArea();
        public abstract override string ToString();
        public abstract void MoveTo(Point destination);
        public abstract void Move(double x, double y);
        public abstract void MoveVertically(double y);
        public abstract void MoveHorizontally(double x);
    }
}