using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;


namespace Task1
{
    class Program

    {
        static void Main(string[] args)
        {
            const int count = 5;
            Product[] products = new Product[count];

            for (int i = 0; i < count; i++)
            {

                Console.WriteLine("Введите ID товара:");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите название товара:");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара:");
                double price = Convert.ToInt32(Console.ReadLine());

                products[i] = new Product() { Id = id, Name = name, Price = price };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products,options);
            string path = "../../../../Products.json";
            using (StreamWriter sw = new StreamWriter(path))
            {
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                sw.WriteLine(jsonString);
            }

        }
    }

}

