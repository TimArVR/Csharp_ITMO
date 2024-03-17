using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Создать метод для вычисления объема и площади поверхности куба по длине его ребра.

            Console.WriteLine("Введите длину ребра куба:");
            double edge = Convert.ToDouble(Console.ReadLine());
            double square;
            double volume;
            GetParamsCube(edge, out square, out volume);
            Console.WriteLine("Объем куба = {0:f2} \nПлощадь поверхности = {1:f2}", volume, square);
        }
        static void GetParamsCube(double a, out double s, out double v)
        {
            s = 6 * a * a;
            v = a * a * a;
        }
    }
}