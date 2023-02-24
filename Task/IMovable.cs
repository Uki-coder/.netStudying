namespace Task
{
    internal interface IMovable
    {
        void MoveTo(Point destination);
        void Move(double x, double y);
        void MoveVertically(double y);
        void MoveHorizontally(double x);
    }
}
