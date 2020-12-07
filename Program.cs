using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesia
{
    public class Point
    {
        public int x { get; }
        public int y { get; }
        public string text { get; }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Figure
    {
        public double Perimeter;
        public string Name { get; }

        public Figure(Point p1, Point p2, Point p3)
        {
            Name = "Треугольник";
            PerimeterCalculator(p1, p2, p3);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            Name = "Четырёхугольник";
            PerimeterCalculator(p1, p2, p3, p4);
        }

        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            Name = "Пятиугольник";
            PerimeterCalculator(p1, p2, p3, p4, p5);
        }

        public double LengthSide(Point A, Point B)
        {
            int l = Math.Abs(B.x - A.x);
            int h = Math.Abs(B.y - A.y);
            return Math.Sqrt(h * h + l * l);
        }

        void PerimeterCalculator(Point p1, Point p2, Point p3)
        {
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p1);
        }

        void PerimeterCalculator(Point p1, Point p2, Point p3, Point p4)
        {
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p1);
        }

        void PerimeterCalculator(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            Perimeter = LengthSide(p1, p2) + LengthSide(p2, p3) + LengthSide(p3, p4) + LengthSide(p4, p5) + LengthSide(p5, p1);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(0, 0);
            Point p2 = new Point(1, 1);
            Point p3 = new Point(0, 4);
            Figure figure = new Figure(p1, p2, p3);
            Console.WriteLine("Фигура: " + figure.Name);
            Console.WriteLine("P = " + figure.Perimeter);
            Console.ReadKey();
        }
    }
}
