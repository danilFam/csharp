using System;

namespace starter_l7_task2
{
    class Program
    {
        static double Add(double summand1, double summand2)
        {
            double summ = summand1 + summand2;
            return summ;
        }
        static double Sub(double minued, double subtrahend)
        {
            double diff = minued - subtrahend;
            return diff;
        }
        static double Mul(double factor1, double factor2)
        {
            double multiplier = factor1 * factor2;
            return multiplier;
        }
        static double Div(double dividend, double divider)
        {
            if (divider != 0)
            {
                return dividend / divider;
            }
            else
            {
                Console.WriteLine("На нуль делить нельзя!");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите математический знак:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        double summ = Add(a, b);
                        Console.WriteLine("Сумма чисел = {0}", summ);
                        break;
                    }
                case "-":
                    {
                        double sub = Sub(a, b);
                        Console.WriteLine("Разность чисел = {0}", sub);
                        break;
                    }
                case "*":
                    {
                        double mul = Mul(a, b);
                        Console.WriteLine("Произведение чисел = {0}", mul);
                        break;
                    }
                case "/":
                    {
                        Console.WriteLine("Частное чисел = {0}", Div(a, b));
                        break;
                    }
                default:
                    Console.WriteLine("Вы ввели не математический знак!");
                    break;
            }
        }
    }
}
