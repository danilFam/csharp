﻿using System;

namespace essential_l1_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(new Point("A", 1, 1), new Point("B", 1, 4), new Point("C", 4, 4));
            Console.Write("{0}, P=", figure.Type);
            figure.PerimeterCalculator();

        }
    }
}
