using System;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using Task2;


namespace Task2
{
    class Program

    {
        static void Main(string[] args)
        {
            string path = "../../../../Products.json";
            string jsonString=String.Empty;
            using (StreamReader sr = new StreamReader(path))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            Product maxPrice = products[0];
            foreach (Product prod in products) 
            {
                if (prod.Price>maxPrice.Price)
                {
                    maxPrice = prod;
                }
            }
            Console.WriteLine($"Максимальная цена товара ID {maxPrice.Id} {maxPrice.Name} равна {maxPrice.Price}");
        }
    }

}

