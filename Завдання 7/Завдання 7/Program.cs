using System;
using System.Text;

namespace Lab2Work7
{
    class Employee
    {
        public static string Name, Surname, Number;
        public static double Oklad, zNalogom,age,zp;
        
        public Employee()
        {
            Console.WriteLine("Введіть ваше ім'я: ");
            Name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть вашу фамілію: ");
            Surname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть стаж роботи: ");
            age = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Оберіть вашу посаду: ");
            Console.WriteLine("Введіть -1- якщо ви - Junior розробник ");
            Console.WriteLine("Введіть -2- якщо ви - Middle розробник ");
            Console.WriteLine("Введіть -3- якщо ви - Senior розробник ");
            Number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть вашу заробітню плату ");
            zp = double.Parse(Console.ReadLine());
            Employee.Calculator();
        }
        public static void Calculator()
        {
            if (Number == "1")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Junior розробник");
                zNalogom = zp * 0.2 / age;
                zNalogom = zp - zNalogom;
                Console.WriteLine("Налог: " + zNalogom);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Number == "2")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Middle розробник");
                zNalogom = zp * 0.2 / age;
                Oklad = zp - zNalogom;
                Console.WriteLine("Налог: " + zNalogom);
                Console.WriteLine("Оклад: " + Oklad);
            }
            else if (Number == "3")
            {
                Console.WriteLine("Ім'я: " + Name);
                Console.WriteLine("Фамілія: " + Surname);
                Console.WriteLine("Посада: Senior розробник");
                zNalogom = zp * 0.2 / age;
                Oklad = zp - zNalogom;
                Console.WriteLine("Налог: " + zNalogom);
                Console.WriteLine("Оклад: " + Oklad);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var znaki = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = znaki;
            Employee employee = new Employee();
            Console.ReadLine();
        }
    }
}
