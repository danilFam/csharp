using System;

namespace essential_l1_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.WriteLine("Введите автора книги:");
            book.Author = Console.ReadLine();
            Console.WriteLine("Введите название книги:");
            book.Tittle = Console.ReadLine();
            Console.WriteLine("Введите содержимое книги:");
            book.Content = Console.ReadLine();
            Console.WriteLine("Ваша книга:");
            book.Show();
        }
    }
}
