using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Два треугольника заданы длинами своих сторон.
            //Определить, площадь какого из них больше(создать метод для вычисления
            //площади  треугольника по длинам его сторон).Для решения задачи можно использовать формулу Герона

            Console.WriteLine("Введите стороны первого треугольника:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            double square1 = GetTriangelSquare(a1, b1, c1);
            Console.WriteLine("Введите стороны второго треугольника:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double square2 = GetTriangelSquare(a2, b2, c2);
            if (square1 > square2)
            {
                Console.WriteLine("Площадь первого треугольника больше!");
            }
            else if (square1 < square2)
            {
                Console.WriteLine("Площадь второго треугольника больше!");
            }
            else
            {
                Console.WriteLine("Площади треугольников равны!");
            }
        }
        static double GetTriangelSquare(double a, double b, double c)
        {
            double p = (a + b + c) / (double)2;
            double tempSq = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника: {0:f2}",tempSq);
            return tempSq;
        }
    }
}