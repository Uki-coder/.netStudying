using System.Drawing;

namespace Task.Figures.ColorProperties
{
    internal class Color
    {
        public enum ColorCoding
        {
            TRANSPARENT,
            HEX,
            RGB,
            NAME
        }

        public string ColorName { get; private set; }
        public ColorCoding Coding { get; private set; }

        public Color(string colorName, int coding)
        {
            ColorName = colorName;
            Coding = (ColorCoding)coding;
        }
    }
}
