using System;

namespace starter_l8_task3
{
    class Program
    {
        static int Factorial(int N)
        {
            if (N == 0)
                return 1;
            else
            {
                return N * Factorial(N - 1);
            }
        }
        static void Main(string[] args)
        {
            int N=5, fact = Factorial(N);
            Console.WriteLine("Факториал равен {0}", fact);
            Console.ReadKey();
        }
    }
}
