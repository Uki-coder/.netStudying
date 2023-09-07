namespace Task.Figures.ColorProperties
{
    /// <summary>
    /// Describes fill of figure: its pattern and color
    /// </summary>
    public class Fill
    {
        /// <summary>
        /// Describes possible pattern of fill
        /// </summary>
        public enum FillPatterns
        {
            None,
            SmallDots,
            Solid,
            Dots,
            Striped,
            WavyStriped,
            HugeDots
        }

        /// <summary>
        /// Describes color of fill
        /// </summary>
        public Color Color { get; set; }
        
        /// <summary>
        /// Describes pattern of fill
        /// </summary>
        public FillPatterns Pattern { get; set; }


        /// <summary>
        /// Creates fill of figure
        /// </summary>
        /// <param name="color">Gives color of fill</param>
        /// <param name="pattern">Gives pattern to fill</param>
        public Fill(Color color, int pattern)
        {
            Color = color;
            Pattern = (FillPatterns)pattern;
        }
    }
}
