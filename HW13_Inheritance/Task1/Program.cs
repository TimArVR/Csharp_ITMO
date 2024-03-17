using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Санкт-Петербург, Кронверкский проспект, 49 ", 100, 250, 150);
            Console.WriteLine(building.Print());

            MultiBuilding multibuilding = new MultiBuilding("Казань, улица Кремлевская, 3", 75, 34, 55, 2);
            Console.WriteLine(multibuilding.Print());
        }

    }

}