using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp1
{
    public static class MyColors
    {
        public static Color RGB(int r, int g, int b)
        {
            return Color.FromArgb(255, (byte)r, (byte)g, (byte)b);
        }
        public static List<Color> Gradient(Color c1, Color c2, int size)
        {
            var colorList = new List<Color>();
            var rMin = c1.R;
            var rMax = c2.R;
            var gMin = c1.G;
            var gMax = c2.G;
            var bMin = c1.B;
            var bMax = c2.B;
            for (int i = 0; i < size; i++)
            {
                var rAverage = rMin + ((rMax - rMin) * i / size);
                var gAverage = gMin + ((gMax - gMin) * i / size);
                var bAverage = bMin + ((bMax - bMin) * i / size);
                colorList.Add(Color.FromArgb(rAverage, gAverage, bAverage));
            }
            return colorList;
        }
    }
}
