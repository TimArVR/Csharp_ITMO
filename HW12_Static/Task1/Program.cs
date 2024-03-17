using System;

namespace Task1
{
    class Program
    {
        //Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
        //метод, определяющий длину окружности по заданному радиусу;
        //метод, определяющий площадь круга по заданному радиусу;
        //метод, проверяющий принадлежность точки с координатами(x, y) кругу с радиусом r и координатами центра x0, y0.

        static void Main(string[] args)
        {

            double radius = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            double length = Circle.GetCircleLength(radius);
            double area = Circle.GetCircleArea(radius);
            bool pointBelongs = Circle.GetPointBelongsToCircle(radius, x, y);

            Console.WriteLine($"Длина окружности: {length} \nПлощадь круга: {area}");
            if (pointBelongs) 
            { 
                Console.WriteLine("Точка принадлежит кругу!");
            }
            else 
            { 
                Console.WriteLine("Точка не принадлежит кругу!"); 
            }
        }

    }

}