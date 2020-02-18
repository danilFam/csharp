using System;

namespace essential_l1_task2
{
    class Rectangle
    {
        private double side1=0, side2=0;

        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
       
        public double AreaCalculator(double side1, double side2)
        {
           return side1 * side2;
        
        }
        public double PerimeterCalculator()
        {
            return (side1 + side2) * 2;
        }

        public double Area
        {
            get { return AreaCalculator(side1,side2); }
        }
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника:");
            double  side1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ширину прямоугольника:");
            double  side2= Convert.ToDouble(Console.ReadLine());
            Rectangle sides = new Rectangle(side1, side2);
            Console.WriteLine("Площадь прямоугольника = {0}",sides.Area);
            Console.WriteLine("Периметр прямоугльника = {0}", sides.Perimeter);

        }
    }
}
