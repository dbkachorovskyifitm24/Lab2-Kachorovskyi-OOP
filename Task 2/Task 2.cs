using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Point
    {
        private double x;
        private double y;
        private string name;
        public Point(double x, double y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
        public double X
        {
            get { return x; }
        }
        public double Y
        {
            get { return y; }
        }
        public string Name
        {
            get { return name; }
        }
    }
    class Figure
    {
        private Point[] points;

        public Figure(Point p1, Point p2, Point p3)
        {
            points = new Point[] { p1, p2, p3 };
        }
        public Figure(Point p1, Point p2, Point p3, Point p4)
        {
            points = new Point[] { p1, p2, p3, p4 };
        }
        public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
        {
            points = new Point[] { p1, p2, p3, p4, p5 };
        }

        public double GetSideLength(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }
        public double CalculatePerimeter()
        {
            double perimeter = 0;

            for (int i = 0; i < points.Length; i++)
            {
                Point current = points[i];
                Point next = points[(i + 1) % points.Length];
                perimeter += GetSideLength(current, next);
            }

            return perimeter;
        }
        public string Name
        {
            get { return points.Length + "-кутник"; }
        }
    }
    class Program
    {
        static void Main()
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(3, 0, "B");
            Point C = new Point(3, 4, "C");

            Figure triangle = new Figure(A, B, C);

            Console.WriteLine("Фiгура: " + triangle.Name);
            Console.WriteLine("Периметр: " + triangle.CalculatePerimeter());

            Console.ReadKey();
        }
    }
}
