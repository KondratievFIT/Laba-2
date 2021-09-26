using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання_2
{
    class Rectangle
    {
        static public double _side1, _side2;
        public double Side1
        {
            get
            {
                return _side1;
            }
        }
        public double Side2
        {
            get
            {
                return _side2;
            }
        }
        public Rectangle()
        {
            Console.WriteLine("Введіть першу сторону");
            _side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть другу сторону");
            _side2 = Convert.ToDouble(Console.ReadLine());
        }
        static public void AreaCalculator()
        {
            double Area = _side1  * _side2;
            Console.WriteLine(Area);
        }
        static public void PerimeterCalculator()
        {
            double Perimetr = 2 * (_side1 + _side2);
            Console.WriteLine(Perimetr);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle Example = new Rectangle();
            Console.WriteLine("Площа: ");
            Rectangle.AreaCalculator();
            Console.WriteLine("Периметр: ");
            Rectangle.PerimeterCalculator();

        }
    }
}
