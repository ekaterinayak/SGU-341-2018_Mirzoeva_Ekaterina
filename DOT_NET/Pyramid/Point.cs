using System;

namespace DOT_NET.Pyramid
{
    class Point
    {
        public double X { get; }
        public double Y { get; }
        public double Z { get; }

        public Point() { }

        public Point(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double GetDistance(Point next)
        {
            return Math.Sqrt(Math.Pow(this.X - next.X, 2) +
                   Math.Pow(this.Y - next.Y, 2) + Math.Pow(this.Z - next.Z, 2));
        }

        override public string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
    }
}
