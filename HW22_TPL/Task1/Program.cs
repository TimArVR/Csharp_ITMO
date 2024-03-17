// Сформировать массив случайных целых чисел (размер  задается пользователем).
// Вычислить сумму чисел массива и максимальное число в массиве.
// Реализовать  решение  задачи  с  использованием  механизма  задач продолжения.

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Action<Task<int[]>> func2 = new Action<Task<int[]>>(ArrayMaxSum);
            Task task2 = task1.ContinueWith(func2);

            task1.Start();
            Console.ReadKey();
        }
        static int[] GetArray(/*int n*/object obj)

        {
            int n = (int)obj;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 10);
                Console.Write($"{array[i]} ");
            }
            return array;
        }
        static void ArrayMaxSum(/*int[] array*/Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];
            int sum = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                sum += array[i];
            }
            Console.WriteLine($"\nМаксимальное значение в массиве {max}");
            Console.WriteLine($"Сумма значений в массиве {sum}");
        }
    }
}