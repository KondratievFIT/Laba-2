using System;

namespace Завдання5
{
    class User
    {
        static public string _login, _name, _lastname;
        static public int _age;
        static private string _date;
        public User()
        {
            Console.WriteLine("Введіть логін:");
            _login = Console.ReadLine();
            Console.WriteLine("Введіть імя:");
            _name = Console.ReadLine();
            Console.WriteLine("Введіть Прізвище:");
            _lastname = Console.ReadLine();
            Console.WriteLine("Введіть вік:");
            _age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть дату:");
            _date = Console.ReadLine();
        }
        static public void Show()
        {
            Console.WriteLine("Логін:");
            Console.WriteLine(_login);
            Console.WriteLine("Імя:");
            Console.WriteLine(_name);
            Console.WriteLine("Прізвище:");
            Console.WriteLine(_lastname); 
            Console.WriteLine("Вік:");
            Console.WriteLine(_age);
            Console.WriteLine("Дата:");
            Console.WriteLine(_date);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            User Example = new User();
            User.Show();
        }
    }
}
