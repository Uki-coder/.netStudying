namespace Task.Interfaces
{
    /// <summary>
    /// Interface that gives scratches abilities to figures objects
    /// </summary>
    internal interface IStretchable
    {
        /// <summary>
        /// Strethches figure by multiplying its side by multiplier given in params
        /// </summary>
        /// <param name="multiplier">Given multiplier that stretches figure relativelly by one point</param>
        void Stretch(double multiplier);
    }
}
