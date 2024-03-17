using System;
using System.Linq;
//Модель  компьютера  характеризуется  кодом  и  названием  марки компьютера,  типом  процессора,  частотой  работы  процессора,
//объемом оперативной памяти, объемом жесткого диска, объемом памяти видеокарты, стоимостью компьютера в условных единицах и количеством
//экземпляров, имеющихся в наличии. Создать список, содержащий 6-10 записей с различным набором значений характеристик.
//Определить:
//-все компьютеры с указанным процессором. Название процессора запросить у пользователя;
//-все компьютеры с объемом ОЗУ не ниже, чем указано. Объем ОЗУ запросить у пользователя;
//-вывести весь список, отсортированный по увеличению стоимости;
//-вывести весь список, сгруппированный по типу процессора;
//-найти самый дорогой и самый бюджетный компьютер;
//-есть ли хотя бы один компьютер в количестве не менее 30 штук?


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
        {
            new Computer () {Model="G3",Name="Dell", Processor="i5", Frequency=2.2, RAMSize=8,HardDisk=256,VideoMemory=2,Price=1200,Quantity=2 },
            new Computer () {Model="G7",Name="Dell", Processor="i9", Frequency=3.2, RAMSize=32,HardDisk=1024,VideoMemory=16,Price=2200,Quantity=1 },
            new Computer () {Model="G5",Name="Dell", Processor="i7", Frequency=2.9, RAMSize=16,HardDisk=512,VideoMemory=8,Price=1900,Quantity=3 },
            new Computer () {Model="IdeaPad",Name="Lenovo", Processor="i3", Frequency=2.2, RAMSize=8,HardDisk=256,VideoMemory=1,Price=900,Quantity=7 },
            new Computer () {Model="TUF",Name="ASUS", Processor="i7", Frequency=3.2, RAMSize=8,HardDisk=512,VideoMemory=4,Price=2200,Quantity=2 },
            new Computer () {Model="ROG",Name="ASUS", Processor="i9", Frequency=3.9, RAMSize=16,HardDisk=2048,VideoMemory=16,Price=4200,Quantity=4 },
            new Computer () {Model="Katana",Name="MSI", Processor="i7", Frequency=4.2, RAMSize=32,HardDisk=1024,VideoMemory=12,Price=3400,Quantity=30 },
            new Computer () {Model="Katana",Name="MSI", Processor="i9", Frequency=3.4, RAMSize=16,HardDisk=512,VideoMemory=8,Price=2400,Quantity=1 }

        };

            Console.WriteLine("Введите модель процессора:");
            string proc = Console.ReadLine();
            List<Computer> computers1 = computers.Where(x => x.Processor == proc).ToList();
            Print(computers1);

            Console.WriteLine("Введите объем ОЗУ, не ниже которого нужны данные:");
            int ram = Convert.ToInt32(Console.ReadLine());
            List<Computer> computers2 = computers.Where(x => x.RAMSize >= ram).ToList();
            Print(computers2);

            List<Computer> computers3 = computers.OrderBy(x => x.Price).ToList();
            Print(computers3);

            IEnumerable<IGrouping<string, Computer>> computers4 = computers.GroupBy(x => x.Processor);
            foreach (IGrouping<string, Computer> g in computers4)
            {
                Console.WriteLine(g.Key);
                foreach (Computer c in g)
                {
                    Console.WriteLine($"{c.Model} {c.Name} {c.Processor} {c.Frequency}MHz {c.RAMSize}GB {c.HardDisk}GB {c.VideoMemory}GB {c.Price}USD {c.Quantity}pcs.");
                }
            }

            Computer computer5 = computers.OrderByDescending(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer5.Model} {computer5.Name} {computer5.Processor} {computer5.Frequency}MHz {computer5.RAMSize}GB {computer5.HardDisk}GB {computer5.VideoMemory}GB {computer5.Price}USD {computer5.Quantity}pcs.");
            Computer computer6 = computers.OrderBy(x => x.Price).FirstOrDefault();
            Console.WriteLine($"{computer6.Model} {computer6.Name} {computer6.Processor} {computer6.Frequency}MHz {computer6.RAMSize}GB {computer6.HardDisk}GB {computer6.VideoMemory}GB {computer6.Price}USD {computer6.Quantity}pcs.");

            if (computers.Any(x => x.Quantity >= 30))
            {
                Console.WriteLine("Товар в количестве не менее 30 ед. присутствует");
            }
            else { Console.WriteLine("Отсутствует"); }


        }

        static void Print(List<Computer> computers)
        {
            foreach (Computer c in computers)
            {
                Console.WriteLine($"{c.Model} {c.Name} {c.Processor} {c.Frequency}MHz {c.RAMSize}GB {c.HardDisk}GB {c.VideoMemory}GB {c.Price}USD {c.Quantity}pcs.");
            }
        }


    }


}