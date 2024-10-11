using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1_scb
{
    internal class Point
    {
        private int x;
        private int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point()
        { 
            this.x=0;
            this.y=0;
        }

        public void ToString()
        {
            Console.WriteLine($"(x: {x}, y: {y})");
        }
        public bool Equals(Point other)
        {
            if (other == null)
            {
                return false;
            }

            return this.x == other.x && this.y == other.y;
        }
    }
}
