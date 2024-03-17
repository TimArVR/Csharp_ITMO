using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
            //  Реализовать класс, в котором указанные значения представлены в виде свойств.
            //  Для свойств предусмотреть проверку корректности данных.
            //  Класс должен содержать конструктор для установки начальных значений,
            //  а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного класса.
            //  Осуществить использование объекта в программе.

            //corner.gradus = Convert.ToInt32(Console.ReadLine());
            //corner.minutes = Convert.ToInt32(Console.ReadLine());
            //corner.seconds = Convert.ToInt32(Console.ReadLine());

            int gradus = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());
            int seconds = Convert.ToInt32(Console.ReadLine());

            //Corner corner = new Corner() {_gradus=gradus,_minutes=gradus,_seconds=seconds };

            Corner corner = new Corner(gradus, minutes, seconds);
            double total = corner.ToRadians();
            Console.WriteLine("Радиан: {0}", total);
        }
    }

}