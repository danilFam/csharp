using System;

namespace starter_l8_doptask
{
    class Program
    {
        static void Calculate(ref double a, ref double b, ref double c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        
        }
        static void Main(string[] args)
        {
            double A = 10, B = 20, C = 30;
            Calculate(ref A, ref B, ref C);
            Console.WriteLine($"{A}, {B}, {C}");
        }
    }
}
