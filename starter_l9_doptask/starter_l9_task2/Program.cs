using System;

namespace starter_l9_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива");
            int N = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            double[] array = new double[N];
            for (int i = 0; i < N; i++)
            {
                array[i] = rand.Next(0, 30);
            }
            Console.WriteLine("Ваш массив:");
            for (int i=0; i<N; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.Write("\n");
            Console.Write("Нечетные значения: ");
            double imax = array[0], imin = array[0], sum = 0, sr=0;
            for (int i = 0; i < N; i++)
            {
                if (array[i]>imax)
                {
                    imax = array[i];
                }
                if (array[i] < imin)
                {
                    imin = array[i];
                }
                sum += array[i];
                if (array[i]%2!=0)
                {
                    Console.Write("{0} ",array[i]);
                }
            }
            Console.Write("\n");
            sr = sum / N;
            Console.WriteLine("Наибольшее значение элемента массива: {0}", imax);
            Console.WriteLine("Наименьшее значение элемента массива: {0}", imin);
            Console.WriteLine("Сумма элементов массива: {0}", sum);
            Console.WriteLine("Среднее арифметическое элементов: {0}", sr);
        }
    }
}
