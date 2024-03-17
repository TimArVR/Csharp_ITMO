using System;
using System.IO;

namespace Task2 
{
    class Program 
    {   
        static void Main(string[] args) 
        {
            //Выберите любую папку на своем компьютере, имеющую вложенные директории.
            //Выведите на консоль ее содержимое и содержимое всех подкаталогов.

            string path = @"D:\repos_C#\ITMO_CSharp_Learning\Temp";
            string [] files = Directory.GetFiles(path,"*.*",SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

        }
    }

}