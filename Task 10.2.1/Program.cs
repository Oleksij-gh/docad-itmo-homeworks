using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradus, min, sec;
            Console.Write("Введите градусы: ");
            gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите минуты: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите секунды: ");
            sec = Convert.ToInt32(Console.ReadLine());

            Edge edge = new Edge(gradus, min, sec);
            Console.WriteLine("При переводе в радианы: {0:F5}", edge.ToRadians());
            Console.ReadKey();
        }
    }
}
