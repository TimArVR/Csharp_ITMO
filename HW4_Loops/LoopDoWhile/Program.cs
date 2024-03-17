using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных
            //или количество отрицательных.
            //Последовательность потенциально не ограничена, окончанием последовательности служит число 0.

            int plusCount = 0;
            int minusCount = 0;
            int currNum;

            do
            {
                Console.WriteLine("Введите целое число:");
                currNum = Convert.ToInt32(Console.ReadLine());
                if (currNum > 0)
                {
                    plusCount++;
                }
                else if (currNum < 0)
                {
                    minusCount++;
                }
                else
                {
                    break;//чтобы выйти при первом вводе 0
                }
            } while (currNum != 0);

            if (plusCount > minusCount)
            {
                Console.WriteLine("Положительных чисел введено больше!");
            }
            else if (plusCount < minusCount)
            {
                Console.WriteLine("Отрицательных чисел введено больше!");
            }
            else if (plusCount == minusCount)
            {
                Console.WriteLine("Введено одинкаковое количество положительных и отрицательных чисел!");
            }
            else
            {
                Console.WriteLine("Вы ввели только ноль!");
            }
        }
    }
}

