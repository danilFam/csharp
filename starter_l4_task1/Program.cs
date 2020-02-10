using System;

namespace starter_l4_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int operand1 = 100, operand2 = 50;
            Console.WriteLine("Please enter the math sign:");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "+":
                    {
                        int summ = operand1 + operand2;
                        Console.WriteLine($"Сумма чисел= {summ}");
                        break;
                    }
                case "-":
                    {
                        int razn = operand1 - operand2;
                        Console.WriteLine($"Разность чисел= {razn}");
                        break;
                    }
                case "*":
                    {
                        int compos = operand1 * operand2;
                        Console.WriteLine($"Произведение чисел= {compos}");
                        break;
                    }
                case "/":
                    {
                        if (operand2 == 0)
                        {
                            Console.WriteLine("На нуль делить нельзя");
                            break;
                        }
                        else
                        {
                            float division = operand1 / operand2;
                            Console.WriteLine($"Частное чисел= {division}");
                            break;
                        }

                    }
                default:
                    Console.WriteLine("Вы ввели не математический знак");
                    break;
            }
            Console.ReadKey();
        }
    }
}
