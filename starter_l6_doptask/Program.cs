using System;

namespace starter_l6_doptask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ширину");
            int w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Прямоугольник высотой {0} и шириной {1}:", h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
