using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
namespace Task_16._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int count = 5;
            int code;
            string name;
            double price;

            Product[] products = new Product[count];

            for (int i = 0; i < count; i++)
            {
                Console.Write("Введите код товара: ");
                code = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите название товара: ");
                name = Console.ReadLine();
                Console.Write("Введите цену товара: ");
                price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                products[i] = new Product() { Code = code, Name = name, Price = price };

            }

            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };

            string jsonString = JsonSerializer.Serialize(products);

            using (StreamWriter streamWriter = new StreamWriter("../../../Products.json"))
            {
                streamWriter.WriteLine(jsonString);
            }

        }
    }
}
