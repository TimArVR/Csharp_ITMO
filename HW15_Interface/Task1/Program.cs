using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.SetStart(10);
            arith.SetStep(2);
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            arith.Reset();
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            GeomProgression geom = new GeomProgression();
            geom.SetStart(10);
            geom.SetStep(2);
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            geom.Reset();
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
        }
    }
}
