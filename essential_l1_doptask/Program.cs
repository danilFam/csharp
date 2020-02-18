using System;

namespace essential_l1_doptask
{
    class Address
    {
        private string index, house, apartment;
        private string country, city, street;

        public string Index
        {
            set { index = value; }
            get { return index; }
        }

        public string House
        {
            set { house = value; }
            get { return house; }
        }
        public string Apartment
        {
            set { apartment = value; }
            get { return apartment; }
        }
        public string Country
        {
            set { country = value; }
            get { return country; }
        }
        public string City
        {
            set { city = value; }
            get { return city; }
        }
        public string Street
        {
            set { street = value; }
            get { return street; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            Console.WriteLine("Введите страну:");
            address.Country = Console.ReadLine();
            Console.WriteLine("Введите город:");
            address.City = Console.ReadLine();
            Console.WriteLine("Введите улицу:");
            address.Street = Console.ReadLine();
            Console.WriteLine("Введите индекс:");
            address.Index = Console.ReadLine();
            Console.WriteLine("Введите дом:");
            address.House = Console.ReadLine();
            Console.WriteLine("Введите квартиру:");
            address.Apartment = Console.ReadLine();
            Console.WriteLine($"Вы проживаете по адресу: {address.Country}, {address.Index}, г.{address.City}, ул.{address.Street}, д.{address.House}, кв.{address.Apartment}") ;

        }
    }
}
