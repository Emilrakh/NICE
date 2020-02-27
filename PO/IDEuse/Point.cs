using System;

namespace IDEuse
{
    /// <summary>
    /// Point of figure
    /// </summary>
    public class Point
    {
        /// <summary>
        /// Coordinate x
        /// </summary>
        public double x { get; }
        /// <summary>
        /// Coordinate y
        /// </summary>
        public double y { get; }
        
        public Point(double  _x, double _y)
        {
            x = _x;
            y = _y;
        }
        
        public static double getDistance(Point first,Point second)
        {
            var x1 = first.x;
            var y1 = first.y;
            var x2 = second.x;
            var y2 = second.y;
            
            var distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            return distance;
        }
        
        public static Point operator + (Point first,Point second)
        {
            return new Point(first.x + second.x,first.y + second.y);
        }
        
        public override string ToString()
        {
            return $"({x},{y})";
        }
    }
}