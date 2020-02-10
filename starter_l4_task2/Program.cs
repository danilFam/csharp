using System;

namespace starter_l4_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число от 0 до 100");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            if (0 <= num && num <= 14)
            {
                Console.WriteLine("Указанное число входит в диапазон [0-14]");
            }
            else if (15 <= num && num <= 35)
            {
                Console.WriteLine("Указанное число входит в диапазон [15-35]");
            }
            else if (36 <= num && num <= 50)
            {
                Console.WriteLine("Указанное число входит в диапазон [36-50]");
            }
            else if (51 <= num && num <= 100)
            {
                Console.WriteLine("Указанное число входит в диапазон [51-100]");
            }
            else
            {
                Console.WriteLine("Указанное число не входит в диапазон [0-100], укажите другое число");
            }
            Console.ReadKey();
        }
    }
}
