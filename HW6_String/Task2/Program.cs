using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом
            //без учёта пробелов и регистра (пример палиндрома – «А роза упала на лапу Азора»).

            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            string str2 = "";

            foreach (char c in str)
            {
                str2 = c + str2;
            }
            str2 = str2.Replace(" ", "");

            bool equal = str.Equals(str2, StringComparison.OrdinalIgnoreCase);

            if (equal)
            {
                Console.WriteLine("Это палидром!");
            }
            else
            {
                Console.WriteLine("Это не палидром!");
            }
        }
    }
}
