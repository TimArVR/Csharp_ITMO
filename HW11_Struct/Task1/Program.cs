using System;
using System.Diagnostics.Metrics;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Разработать структуру для решения линейного уравнения 0=kx+b.
            //  Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа.
            //  Для решения уравнения предусмотреть метод Root.
            //  Создать экземпляр разработанной структуры. Осуществить использование экземпляра в программе.

            Console.WriteLine("Введите поочередно коэффициенты к и b линейного уравнения:");
            double coefK = Convert.ToDouble(Console.ReadLine());
            double coefB = Convert.ToDouble(Console.ReadLine());

            LinearEquation linearEquation = new LinearEquation(coefK,coefB);
            Console.WriteLine(linearEquation.Root());
        }
    }

}