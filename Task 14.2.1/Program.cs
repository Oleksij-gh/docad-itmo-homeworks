using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cat cat = new Cat("Мурка");
            cat.ShowInfo();
            Console.WriteLine();
            Dog dog = new Dog("Жучка");
            dog.ShowInfo();

            Console.ReadKey();
        }
    }
}
