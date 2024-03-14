using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
namespace Task_16._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;

            using (StreamReader streamReader = new StreamReader("../../../Products.json"))
            {
                jsonString = streamReader.ReadToEnd();
            }

            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);

            string name = String.Empty;
            double price = double.MinValue;

            foreach (Product product in products)
            {
                if (product.Price > price)
                {
                    price = product.Price;
                    name = product.Name;
                }
            }

            Console.WriteLine($"Самым дорогим является продукт {name} с ценой {price}");
            Console.ReadKey();
        }
    }
}
