using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Доброе пожаловать в калькулятор!\nВведита число A:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введита число B:");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите код операции:\n   1 - Сложение\n   2 - Вычитание\n   3 - Произведение\n   4 - Частное\n");
                int c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ваш выбор: {0}", c);
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат = {0:f2}", a + b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат = {0:f2}", a - b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат = {0:f2}", a * b);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Результат = {0:f2}", a / b);
                            break;
                        }
                    default:
                    {
                        Console.WriteLine("Введен неверный номер операции");
                        break;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Деление на ноль!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Неверный ввод!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}