//Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать.
//Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. Первый садовник начинает работу
//с верхнего левого угла сада и перемещается слева направо, сделав ряд, он спускается вниз. Второй садовник начинает работу
//с нижнего правого угла сада и перемещается снизу вверх, сделав ряд, он перемещается влево. Если садовник видит,
//что участок сада уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно.
//Создать многопоточное приложение, моделирующее работу садовников.

namespace Task1
{
    class Program
    {
        const int n = 5;
        static readonly int[,] path = new int[n, n]
        {
        {1,2,3,4,5},
        {5,4,3,2,5},
        {100,5,2,4,3},
        {7,8,3,5,1},
        {1,0,3,3,4}
        };

        static void Main(string[] args)

        {
            ThreadStart threadStart = new ThreadStart(Gardner1);
            Thread thread = new Thread(threadStart);
            thread.Start();
            Gardner2();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{path[i, j]} ");
                    if (j == n - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
        static void Gardner1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -1;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
        static void Gardner2()
        {
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = n - 1; j >= 0; j--)
                {
                    if (path[i, j] >= 0)
                    {
                        int delay = path[i, j];
                        path[i, j] = -2;
                        Thread.Sleep(delay);
                    }
                }
            }
        }
    }
}
