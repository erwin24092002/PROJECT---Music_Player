using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    public class MyColors
    {
        public Color[] RGBColors;
        public MyColors()
        {
            // Color
            RGBColors = new Color[5];
            RGBColors[0] = Color.FromArgb(172, 12, 241);
            RGBColors[1] = Color.FromArgb(249, 118, 176);
            RGBColors[2] = Color.FromArgb(95, 77, 221);
            RGBColors[3] = Color.FromArgb(249, 88, 155);
            RGBColors[4] = Color.FromArgb(24, 161, 251);
        }
    }
}
