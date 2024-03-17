using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50].
            //Определить сумму максимального и минимального элементов массива.

            const int n = 15;
            Random rnd = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Максмальное значение: {0}", max);
            Console.WriteLine("Минимальное значение: {0}", min);
        }
    }
}

