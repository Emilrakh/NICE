using System;

namespace IDEuse
{
    public class Rectangle
    {
        private Point A { get; set; }
        private Point B { get; set; }
        private Point C { get; set; }
        private Point D { get; set; }

        private double height => Point.getDistance(A, B);
        private double width => Point.getDistance(A, D);
        
        public Rectangle(Point _A, Point _B, Point _C, Point _D)
        {
            A = _A;
            B = _B;
            C = _C;
            D = _D;
        }

        public double getPerimeter() => 2.0 * (height + width);
        
        public double getSquare() => height * width;

        public double getDiagonal() => Point.getDistance(A, C);
        
        public double circleRadius() => Math.Sqrt(height*height + width*width)/2;
        
        public double angelBetween() => Math.Sin(height/Point.getDistance(A, C));
        
        public Rectangle moveFigure(Point coordinates)
        {
            A += coordinates;
            B += coordinates;
            C += coordinates;
            D += coordinates;
            return this;
        }

        public override string ToString()
        {
           return  $"A:({A.x},{A.y}) B:({B.x},{B.y}) C:({C.x},{C.y}) D:({D.x},{D.y})";
        }
    }
}