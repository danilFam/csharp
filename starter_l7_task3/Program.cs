using System;

namespace starter_l7_task3
{
    class Program
    {
        static double exchange(int currency, double koeff)
        {
            return currency * koeff;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму:");
            int currency = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите курс конвертации:");
            double koeff = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы получите {0} денег", exchange(currency, koeff));
            Console.ReadKey();
        }
    }
}
