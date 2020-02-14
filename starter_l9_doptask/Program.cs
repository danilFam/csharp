using System;

namespace starter_l9_doptask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for( int i=0; i<array.Length; i++)
            {
                array[i]= i+1;
            }
            for (int i = array.Length-1; i>=0; i--)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();

        }
    }
}

