using System;

namespace starter_l6_taks2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число, которое больше первого:");
            int B = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int sum1 = A, sum2 = B;
            while ((sum2 - sum1) > 1)
            {
                sum += ++sum1;
            }
            Console.WriteLine("Сумма чисел= {0}", sum);
            Console.Write("Все нечетные числа в промежутке от {0} до {1}: ", A, B);
            int a = A, b = B;
            while (a < b)
            {
                a++;
                if (a % 2 != 0)
                    Console.Write(a + ",");
                
            }
            Console.WriteLine("Roma privet!");
        }
    }
}
