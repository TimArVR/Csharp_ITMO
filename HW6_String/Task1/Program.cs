using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом.
            //Знаки препинания не используются. Найти самое длинное слово в строке.

            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = "";

            foreach (string s in strArray)
            {
                if (s.Length > max.Length) 
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
        }
    }
}
