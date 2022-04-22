using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ColorAndBall
{
    public class Color
    {
        public int Red { set; get; }
        public int Green { set; get; }
        public int Blue { set; get; }
        public int Alpha { set; get; }

        public Color(int red, int green, int blue, int alpha = 255)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public double GrayScale()
        {
            return Red + Green + Blue / 3;
        }
    }
}
