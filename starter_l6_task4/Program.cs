using System;

namespace starter_l6_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество клиентов");
            int count = Convert.ToInt32(Console.ReadLine());
            int fact = 1, factorial = 1;
            do
            {
                factorial *= fact++;
            }
            while (fact <= count);
            Console.WriteLine("Количество возможных вариантов доставки: {0}", factorial);
        }
    }
}
