namespace Task1
{
    //В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
    //-  метод получает входным параметром переменную типа double;
    //- метод возвращает значение типа double, которое является результатом вычисления.
    //Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
    //- длину окружности по формуле D = 2 * π * R;
    //- площадь круга по формуле S = π* R²;
    //- объем шара.Формула V = 4 / 3 * π * R³.
    class Program
    {
        delegate double MyDelegate(double x);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = CircleLength;
            double temp = myDelegate(10);
            Console.WriteLine(temp);

            myDelegate = CircleArea;
            temp = myDelegate(9);
            Console.WriteLine(temp);

            myDelegate = SphereVolume;
            temp = myDelegate(8);
            Console.WriteLine(temp);

            //MyDelegate myDelegate = CircleLength;
            //myDelegate += CircleArea;
            //myDelegate += SphereVolume;
        }

        //static double CircleLength(double r)
        //{ 
        //return 2*Math.PI*r;
        //}
        //static double CircleArea (double r) 
        //{
        //    return Math.PI*r*r;
        //}
        //static double SphereVolume (double r) 
        //{
        //return 4.0/3*Math.PI*Math.Pow(r,3);
        //}

        static double CircleLength(double r) => 2 * Math.PI * r;
        static double CircleArea(double r) => Math.PI * r * r;
        static double SphereVolume(double r) => 4.0 / 3 * Math.PI * Math.Pow(r, 3);




    }


}