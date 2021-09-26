using System;
using System.Text;

namespace Lab2Work4
{
    class Point
    {
        public int Coordinate_X { get; }
        public int Coordinate_Y { get; }
        public string Name { get; }
        public Point(int x, int y, string name)
        {
            Coordinate_X = x;
            Coordinate_Y = y;
            Name = name;
        }
    }
    class Figure
    {
        public static int e;

        public Point[] points { get; }
        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }
        public double LengthSize(Point point1, Point point2)
        {
            return Math.Sqrt(Math.Pow(point1.Coordinate_X - point2.Coordinate_X, 2) + Math.Pow(point1.Coordinate_Y - point2.Coordinate_Y, 2));
        }
        public void PerimeterCalculator()
        {
            double Perimeter = 0;
            for (int i = 0; i < e ; i++)
            {
                if (i == points.Length - 1)
                {
                    Perimeter += LengthSize(points[i], points[0]);
                }
                else
                {
                    Perimeter += LengthSize(points[i], points[i + 1]);
                }
            }
            Console.WriteLine("Периметр = " + Perimeter);
        }
        public void GetName()
        {
            Console.WriteLine("Введіть к-ть кутів");
            e = int.Parse(Console.ReadLine());
            if (e < 3 )
            {
                Console.WriteLine("К-ть кутів не може бути менше 3");
                Environment.Exit(-1);
            }
            int schet = 0;
            for (int i = 0; i < points.Length - e; i++)
            {
                schet++;

            }
            if(schet ==3)
            {
                Console.WriteLine("Трикутник");
            }
            else if (schet == 4)
            {
                Console.WriteLine("Чотирикутник");
            }
            else if(schet == 5)
            {
                Console.WriteLine("Пятикутник");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            Console.OutputEncoding = Encoding.UTF8;
            Figure figure = new Figure(new Point(0, 2, "Point1"), new Point(0, 0, "Point2"), new Point(2, 0, "Point3"), new Point(2, 2, "Point4"), new Point(1, 1, "Point5"));
            figure.GetName();
            figure.PerimeterCalculator();
            Console.ReadLine();
        }
    }
}
