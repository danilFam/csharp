using System;

namespace starter_l7_doptask
{
    class Program
    {
        static double Calculate(double a, double b, double c)
        {
            double sr = (a + b + c) / 3;

            return sr;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            double c = Convert.ToDouble(Console.ReadLine());
            double sr = Calculate(a, b, c);
            Console.WriteLine("Среднее арифметическое чисел= {0}", sr);
            Console.ReadKey();
        }
    }
}
