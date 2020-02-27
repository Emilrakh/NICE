using System;

namespace IDEuse
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(1, 1);
            var rectangle = new Rectangle(new Point(0, 0), new Point(5, 0), new Point(5, 10), new Point(0, 10));
            
            Console.WriteLine("Perimeter: " + rectangle.getPerimeter());
            Console.WriteLine("Square: " + rectangle.getSquare());
            Console.WriteLine("Diagonal: " + rectangle.getDiagonal());
            Console.WriteLine("Circle radius: " + rectangle.circleRadius());
            Console.WriteLine("Angel: " + rectangle.angelBetween());
            Console.WriteLine("New coordinates: " + rectangle.moveFigure(point));
            
            var square = new Square(new Point(0, 0), new Point(5, 0), new Point(5, 5), new Point(0, 5));
            
            Console.WriteLine("Perimeter: " + square.getPerimeter());
            Console.WriteLine("Square: " + square.getSquare());
            Console.WriteLine("Diagonal: " + square.getDiagonal());
            Console.WriteLine("Circle radius: " + square.circleRadius());
            var sq1 = new Square(new Point(12, 13), new Point(14, 16), new Point(18, 18), new Point(18, 19));
            var wRectangle = new Rectangle(new Point(12, 14), new Point(151, 17), new Point(18, 18), new Point(17, 17));
            
        }
    }
}