using System;

namespace LoopWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу:
            //N^2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы
            //(в результате будут выведены квадраты всех целых чисел от 1 до N).

            Console.WriteLine("Введите целое число");
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            for (int i = 1; i <= (2 * n - 1); i += 2)
            {
                result += i;
                Console.WriteLine("Текущее значение: {0}", result);
            }
        }
    }

}
