//Асинхронно факториал числа
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое неотрицательное число, факториал которого надо рассчитать:");
            int n = Convert.ToInt32(Console.ReadLine());
            FactorAsync(n);
            //продолжится выполнение метода маин после зыввуска асинхронной задачи
            Console.ReadKey();
        }
        static void Factorial(int n)
        {
            if (n == 0)
            {
                Console.WriteLine("Факториал 0 равен 1");
            }
            else if (n < 0)
            {
                Console.WriteLine("Введите целое неотрицательное число");
            }
            else
            {
                int f = 1;
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Факториал {n} равен {f}");
            }
        }

        static async void FactorAsync(int n)
        {
            await Task.Run(()=>Factorial(n)); //напр это длительная операция, чтобы не приостанавливать остальное выполнение программы горячий таск и пишем await
        }

    }
}
