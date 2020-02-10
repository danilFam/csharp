using System;

namespace starter_l3_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string number1 = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string number2 = Console.ReadLine();
            Console.WriteLine("Введите третье число");
            string number3 = Console.ReadLine();
            double num1 = Convert.ToDouble(number1), num2 = Convert.ToDouble(number2), num3 = Convert.ToDouble(number3);
            double sr = (num1 + num2 + num3) / 3;
            Console.WriteLine("Среднее арифметическое чисел= {0}", sr);
            Console.ReadKey();
        }
    }
}
