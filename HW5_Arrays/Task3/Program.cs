using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50].
            //Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.

            const int n = 10;
            Random rnd = new Random();
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            for (int i = 5; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}

