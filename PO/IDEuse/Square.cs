using System;

namespace IDEuse
{
    public class Square
    {
        private Point A { get; }
        private Point B { get; }
        private Point C { get; }
        private Point D { get; }

        private double side => Point.getDistance(A, B);
        
        public Square(Point _A, Point _B, Point _C, Point _D)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
        }
        
        public double getPerimeter() => 4.0 * side;
        
        public double getSquare() => side * side;
        
        public double getDiagonal() => Point.getDistance(A, C);
        
        public double circleRadius() => Math.Sqrt(2 * side*side)/2;
    }
}