using System;
using System.Text;

namespace Lab2Work6
{
    class Converter
    {
        private static double Sum, Output;
        private static string Number;
        public Converter(double usd, double eur, double rub)
        {
            Console.WriteLine("Оберіть валюту для обміну: ");
            Console.WriteLine("Щоб конвертувати UAH в Usd Введіть -1-");
            Console.WriteLine("Щоб конвертувати UAH в Eur Введіть -2- ");
            Console.WriteLine("Щоб конвертувати UAH в Rub Введіть -3- ");
            Console.WriteLine("Щоб конвертувати Usd в Uah Введіть -4- ");
            Console.WriteLine("Щоб конвертувати Eur в Uah Введіть -5- ");
            Console.WriteLine("Щоб конвертувати Rub в Uah Введіть -6- ");
            Number = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть СУМУ валюти, що конвертується: ");
            Sum = Convert.ToDouble(Console.ReadLine());
            if (Number == "1")
            {
                Output = Sum / usd;
                Console.WriteLine("USD: " + Output);
            }
            else if (Number == "2")
            {
                Output = Sum / eur;
                Console.WriteLine("EUR: " + Output);
            }
            else if (Number == "3")
            {
                Output = Sum / rub;
                Console.WriteLine("RUB: " + Output);
            }
            else if (Number == "4")
            {
                Output = Sum * usd;
                Console.WriteLine("UAH: " + Output);
            }
            else if (Number == "5")
            {
                Output = Sum * eur;
                Console.WriteLine("UAH: " + Output);
            }
            else if (Number == "6")
            {
                Output = Sum * rub;
                Console.WriteLine("UAH: " + Output);
            }
            else
            {
                Console.WriteLine("Ви ввели невірні данні");
                Console.ReadLine();
                Environment.Exit(-1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var convertt = Encoding.GetEncoding(1251);
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = convertt;
            double usd = 26.4;
            double eur = 31.2;
            double rub = 0.34;
            Converter convert = new Converter(usd, eur, rub);
            Console.ReadLine();
        }
    }
}