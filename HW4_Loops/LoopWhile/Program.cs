using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально
            //возможное количество квадратов со стороной C (без наложений). Найти количество квадратов,
            //размещенных на прямоугольнике. Операции умножения и деления не использовать.

            Console.WriteLine("Введите положительное число А:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число B:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите положительное число C:");
            int c = Convert.ToInt32(Console.ReadLine());

            int countSideA = 0;
            int countSideB = 0;

            if (a < c || b < c)
            {
                Console.WriteLine("Нельзя разместить ни одного квадрата!");

            }
            else
            {
                while (c <= a)
                {
                    a = a - c;
                    countSideA++;
                }
                while (c <= b)
                {
                    b = b - c;
                    countSideB++;
                }

                Console.WriteLine("Количество квадратов: {0}", countSideA * countSideB);
            }
        }
    }
}

