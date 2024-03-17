using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN.
            //Заполнить массив числами, вводимыми с клавиатуры.
            //Проверить, является ли введенная с клавиатуры матрица магическим квадратом.
            //Магическим квадратом называется матрица, сумма элементов которой в каждой строке,
            //в каждом столбце и по каждой диагонали одинакова.
            Console.WriteLine("Введите размерность таблицы:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int[,] array = new int[n, n];

            int[] arrayForSums = new int[2 * n + 2];
            int position = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("Введите значение по строке {0} по столбцу {1}:",i,j);
                    array[i,j] = Convert.ToInt32(Console.ReadLine());
                }

            }

            //Сумма по строкам

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrayForSums[position] += array[i, j];
                }
                position++;
            }

            //Сумма по столбцам

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arrayForSums[position] += array[j, i];
                }
                position++;
            }

            //Сумма по главной диагонали

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==j)
                    {
                        arrayForSums[position] += array[i, j];
                    };
                }
            }

            //Сумма по побочной диагонали
            for (int i = n; i > -1; i--)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        arrayForSums[position] += array[i, j];
                    };
                }
            }

            // Проверка на магию
            int temp = arrayForSums[0];
            int count = 0;
            for (int i = 0; i < position; i++)
            {
                if (arrayForSums[i]==temp)
                {
                    count++;
                }
            }
            if (position==count)
            {
                Console.WriteLine("Матрица магическая!");
            }
            else
            {
                Console.WriteLine("Матрица НЕ магическая!");
            }

        }
    }
}