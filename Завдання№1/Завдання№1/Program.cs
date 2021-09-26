using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Завдання1
{
    class Address
    {
        private string _street;
        private string _country;
        private string _city;
        private int _index;
        private int _house;
        private int _apartment;

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                this._city = value;
            }
        }


        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Індекс не нижче 0 ");
                }
                else
                {
                    this._index = value;
                }

            }
        }
        public int House
        {
            get
            {
                return _house;
            }
            set
            {
                this._house = value;
            }
        }
        public int Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Номер будинку не нижче 0 ");
                }
                else
                {
                    this._apartment = value;
                }
            }
        }
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                this._country = value;
            }
        }
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                this._street = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address Example = new Address();
            Console.WriteLine("Введіть індекс: ");
            Example.Index = int.Parse(Console.ReadLine());
            Console.WriteLine("Введіть країну: ");
            Example.Country = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть місто : ");
            Example.City = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть вулицю: ");
            Example.Street = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введіть номер будинку: ");
            Example.Apartment = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Індекс:" + Example.Index);
            Console.WriteLine("Країна:" + Example.Country);
            Console.WriteLine("Місто:" + Example.City);
            Console.WriteLine("Вулицю:" + Example.Street);
            Console.WriteLine("Номер будинку:" + Example.Apartment);
            Console.ReadKey();

        }

    }
}