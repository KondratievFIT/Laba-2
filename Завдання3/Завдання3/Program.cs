using System;

namespace Завдання3
{
    class Book
    {
        static public void Show()
        {
            Title.Show();
            Author.Show();
            Content.Show();
        }
    }
    class Title
    {
        static public string _title;
        public string title
        {
            get
            {
                return _title;
            }
        }
        public Title()
        {
            Console.WriteLine("Введіть назву книги:");
            _title = Console.ReadLine();
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Назва книги:");
            Console.WriteLine(_title);
        }
    }
    class Author
    {
        static public string _author;
        public Author()
        {
            Console.WriteLine("Введіть імя автора:");
            _author = Console.ReadLine();
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Імя автора:");
            Console.WriteLine(_author);
        }
    }
    class Content
    {
        static public string _content;
        public Content()
        {
            Console.WriteLine("Введіть зміст:");
            _content = Console.ReadLine();
        }
        static public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Зміст книги:");
            Console.WriteLine(_content);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Title Example = new Title();
            Author Example1 = new Author();
            Content Example2 = new Content();
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.UTF8;
            Book.Show();
        }
    }
}
