using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры,
            //определить среднее арифметическое элементов.

            const int n = 7;
            float k = 0;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Введите число {0} из {1}", i + 1, n);
                array[i] = Convert.ToInt32(Console.ReadLine());
                k += array[i];
            }
            Console.WriteLine("Среднее арифметическое: {0:f2}", k/n);
        }
    }
}

