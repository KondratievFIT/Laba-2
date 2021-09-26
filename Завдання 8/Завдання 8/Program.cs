using System;
using System.Text;

namespace Lab2Work8
{
    class Invoice
    {
        int account;
        string customer, provider;
        private static int quantity;
        public static double cost, price;
        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice(string item, int quantity, double price)
        {
            Invoice.quantity = quantity;
            Invoice.price = price;
            Invoice.zHDC();
            Invoice.noHDC();
        }
        public static void zHDC()
        {
            cost = quantity * price * 0.8;
            Console.WriteLine("Ціна товару з НДС: " + cost);
        }
        public static void noHDC()
        {
            cost = quantity * price;
            Console.WriteLine("Ціна товару без НДС " + cost);
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
            Console.WriteLine("Оберіть товар для заказу, наприклад -годинник- ");
            string item = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Кількість? ");
            int quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ціна товару? ");
            double price = Convert.ToDouble(Console.ReadLine());
            Invoice name = new Invoice(12345, "Владислав", "Тимур");
            Invoice prices = new Invoice(item, quantity, price);
        }
    }
}
