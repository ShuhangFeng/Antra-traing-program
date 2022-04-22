using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6.ColorAndBall
{
    public class Ball
    {
        public int Size { set; get; }
        public Color Color { set; get; }
        public int ThrownTimes { set; get; }

        public Ball(Color color, int size = 1, int thrownTimes = 0)
        {
            Color = color;
            Size = size;
            ThrownTimes = thrownTimes;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size > 0)
            {
                ThrownTimes++;
            }
        }
    }
}
