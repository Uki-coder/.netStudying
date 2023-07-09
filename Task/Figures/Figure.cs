using Task.Figures.ColorProperties;
using Task.Interfaces;

namespace Task.Figures
{
    /// <summary>
    /// Abstract class of geometric figure. Has common figure properties: area, name, border, fill
    /// </summary>
    public abstract class Figure : IMovable, IStretchable
    {

        /// <summary>
        /// Area of figure
        /// </summary>
        public double Area { get; protected set; }
        /// <summary>
        /// Type of figure: Circle, Recctangle, Triangle
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Describes border (pattern and color) of current figure
        /// </summary>
        public Border FigureBorder { get; protected set; }

        /// <summary>
        /// Describes fill (pattern and color) of current figure
        /// </summary>
        public Fill FigureFill { get; protected set; }

        /// <summary>
        /// Creates abstract empty figure
        /// </summary>
        public Figure()
        {
            Name = string.Empty;
            FigureBorder = new Border(new Color("", 0), 0);
            FigureFill = new Fill(new Color("", 0), 0);
        }

        /// <summary>
        /// Counts, initialize then returns area of figure
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
        public abstract override string ToString();
        public abstract void MoveTo(Point destination);
        public abstract void Shift(double x, double y);
        public abstract void MoveVertically(double y);
        public abstract void MoveHorizontally(double x);
        public abstract void Stretch(double multiplier);
    }
}