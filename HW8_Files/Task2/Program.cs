using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Программно создайте текстовый файл и запишите в него 10 случайных чисел.
            //Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.

            string path = @"D:\repos_C#\ITMO_CSharp_Learning\Temp\numbers.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            Random rnd = new Random();

            using (StreamWriter sw = new StreamWriter(path, false)) 
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(rnd.Next(-100, 100));
                }
            }

            int sum = 0;
            using (StreamReader sr = new StreamReader(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }

            Console.WriteLine("Сумма чисел в файле: {0}", sum);
        }
    }

}