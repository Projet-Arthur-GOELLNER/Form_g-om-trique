public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public bool Equals(Point point)
        {
            return X == point.X && Y == point.Y;
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }
