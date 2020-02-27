using System;

namespace IDEuse
{
    public class Rectangle2
    {
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }

        public double height => Point.getDistance(A, B);
        public double width => Point.getDistance(A, D);

        public Rectangle2(Point _A, Point _B, Point _C, Point _D)
        {
            if (Point.getDistance(_A, _B) == Point.getDistance(_C, _D) &&
                Point.getDistance(_B, _C) == Point.getDistance(_A, _D))
            {
                A = _A;
                B = _B;
                C = _C;
                D = _D;
            }
            else
            {
                Console.WriteLine("NOT A RECTANGLE");
            }
        }

        public double getPerimetere() => 2.0 * (height + width);

        public double getSquare() => height * width;

        public double getDiagonal() => Point.getDistance(A, C);

        public double circleRadius() => Math.Sqrt(height * height + width * width) / 2;

        public double angelBetween() => Math.Sin(height / Point.getDistance(A, C));

        public Rectangle2 moveFigure(Point coordinates)
        {
            A += coordinates;
            B += coordinates;
            C += coordinates;
            D += coordinates;
            return this;
        }

        public override string ToString()
        {
            return $"A:({A.x},{A.y}) B:({B.x},{B.y}) C:({C.x},{C.y}) D:({D.x},{D.y})";
        }
    }
}