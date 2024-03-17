//Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
//Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
//Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
//Создать  несколько экземпляров класса, параметризированного различными типам.
//Заполнить его поля и вывести на экран информацию об экземпляре класса.

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер счета int");
            //int acc1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите текущий баланс");
            //decimal bal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введите ФИО владельца");
            //string fi = Console.ReadLine();

            //Account<int> owner1 = new Account<int>(acc1, bal, fi);
            //Console.WriteLine(owner1.GetData());

            //Console.WriteLine("Введите номер счета string");
            //string acc2 = Console.ReadLine();
            //Console.WriteLine("Введите текущий баланс");
            //bal = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine("Введите ФИО владельца");
            //fi = Console.ReadLine();

            //Account<string> owner2 = new Account<string>(acc2, bal, fi) { };
            //Console.WriteLine(owner2.GetData());
            Account<int> owner1 = new Account<int>();
            owner1.InputInfo();
            Console.WriteLine(owner1.GetData());

            Account<string> owner2 = new Account<string>();
            owner2.InputInfo();
            Console.WriteLine(owner2.GetData());
        }
    }
}