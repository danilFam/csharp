using System;

namespace starter_l6_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 7, b = 4;

            Console.WriteLine("Прямоугольник {0} на {1}:", a, b);
            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            Console.WriteLine("Прямоугольный треугольник:");
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
