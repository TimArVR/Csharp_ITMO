using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50].
            //Определить количество   нечетных положительных элементов, стоящих на четных местах.

            const int n = 20;
            Random rnd = new Random();
            int k = 0;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < n; i+=2)
            {
                if (array[i]>0 && array[i]%2>0)
                {
                    k++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Количество нечетных чисел на четных местах: {0}", k);

        }
    }
}