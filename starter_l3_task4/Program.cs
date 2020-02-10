using System;

namespace starter_l3_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            int r = 5;
            double S = pi * Math.Pow(r, 2);
            Console.WriteLine("Площадь круга= {0}", S);
            Console.ReadKey();
        }
    }
}
