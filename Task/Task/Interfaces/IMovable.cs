using Task.Figures;

namespace Task.Interfaces
{
    /// <summary>
    /// Interface that gives move abilities for points and figures
    /// </summary>
    internal interface IMovable
    {
        /// <summary>
        /// Move point or figure by its main point relativally to destination point
        /// </summary>
        /// <param name="destination"></param>
        void MoveTo(Point destination);
        /// <summary>
        /// Moves point or figure vertically and horizontally by given params
        /// </summary>
        /// <param name="x">Horizontal change (when negative: moves left)</param>
        /// <param name="y">Vertical change (when negative: moves down)</param>
        void Shift(double x, double y);
        /// <summary>
        /// Moves point or figure vertically by given param
        /// </summary>
        /// <param name="y">Vertical change (when negative: moves down)</param>
        void MoveVertically(double y);
        /// <summary>
        /// Moves point or figure horizontally by given param
        /// </summary>
        /// <param name="x">Horizontal change (when negative: moves left)</param>
        void MoveHorizontally(double x);
    }
}
