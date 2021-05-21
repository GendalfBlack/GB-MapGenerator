using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApp1.MyColors;

namespace WindowsFormsApp1
{
    class BitmapMaps
    {
        public float OceanDepth = 0.2f;
        public float ShoreWidth = 0.3f;
        public float ForestSize = 0.8f;
        public float MountainSize = 0.9f;

        public int OceanDetails = 8;
        public int ShoreDetails = 4;
        public int ForestDetails = 10;
        public int MountainDetails = 4;
        public int SnowDetails = 4;
        public Bitmap CreateMap()
        {
            int height = 500;
            int width = 500;

            var pixel = new Bitmap(height, width);

            float[] t = Noise2d.GenerateNoiseMap(height, width, 12);

            List<Color> ocean = Gradient(RGB(0, 0, 180), RGB(80, 190, 255), OceanDetails);
            List<Color> shore = Gradient(RGB(255, 255, 160), RGB(0, 170, 70), ShoreDetails);
            List<Color> forest = Gradient(RGB(60, 130, 0), RGB(80, 60, 0), ForestDetails);
            List<Color> mountain = Gradient(RGB(80, 60, 0), RGB(45, 35, 0), MountainDetails);
            List<Color> snow = Gradient(RGB(150, 150, 150), RGB(255, 255, 255), SnowDetails);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    float f = t[i * height + j];
                    Color c = RGB(0, 0, 0);
                    try
                    {
                        if (f < OceanDepth)
                        {
                            c = ocean[(int)Noise2d.Map(f, 0, OceanDepth, 0, OceanDetails)];
                        }
                        else if (f < ShoreWidth)
                        {
                            c = shore[(int)Noise2d.Map(f, OceanDepth, ShoreWidth, 0, ShoreDetails)];
                        }
                        else if (f < ForestSize)
                        {
                            c = forest[(int)Noise2d.Map(f, ShoreWidth, ForestSize, 0, ForestDetails)];
                        }
                        else if (f < MountainSize)
                        {
                            c = mountain[(int)Noise2d.Map(f, ForestSize, MountainSize, 0, MountainDetails)];
                        }
                        else
                        {
                            c = snow[(int)Noise2d.Map(f, MountainSize, 1f, 0, SnowDetails)];
                        }
                    }
                    catch (System.ArgumentOutOfRangeException)
                    {
                        c = RGB(255, 255, 255);
                    }
                    pixel.SetPixel(i, j, c);
                }
            }
            return pixel;
        }
    }
}
