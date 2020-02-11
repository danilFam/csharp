using System;

namespace starter_l8_task2
{
    class Program
    {
        static void Credit(double summa)
        {
            double dolg = 700;
            double payment = 100;
            if (summa>payment)
                Console.WriteLine("Сумма переплаты составляет: {0}", (summa-payment));
            dolg -= summa;
            if (dolg>0)
            {
                Console.WriteLine("Сумма задолженности составляет:{0}", dolg);
            }
            else
            {
                Console.WriteLine("Вы погасили кредит!");
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму платежа:");
            double summa = Convert.ToDouble(Console.ReadLine());
            Credit(summa);
        }
    }
}
