using System;

namespace starter_l7_task4
{
    class Program
    {
        static void Sign(int a)
        {
            a = a >> 31;
            if (a == -1)
            {
                Console.WriteLine("Число отрицательное");
            }
            else
            {
                Console.WriteLine("Число положительное");
            }
        }
        static void Remainder(int a)
        {
            if ((a % 2 == 0) && (a % 3 == 0) && (a % 5 == 0) && (a % 6 == 0) && (a % 9 == 0))
            {
                Console.WriteLine("Число делится на 2, 3, 5, 6, 9");
            }
            else
            {
                Console.WriteLine("Число не делится на 2, 3, 5, 6, 9");
            }
        }
        static void Simple(int a)
        {
            int divider;
            int reminder;
            divider = 2;
            do
            {
                reminder = a % divider;
                if (reminder != 0)
                    divider++;
            } while (reminder != 0);
            if (divider == a)
            {
                Console.WriteLine("{0} число простое", a);
            }
            else
            {
                Console.WriteLine("{0} число не простое", a);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Sign(a);
            Remainder(a);
            Simple(a);
        }
    }
}
