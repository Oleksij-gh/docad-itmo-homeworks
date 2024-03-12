using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, z1, x2, y2, z2;
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            z1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            z2 = Convert.ToInt32(Console.ReadLine());

            double s1 = GetSquare(x1, y1, z1);
            double s2 = GetSquare(x2, y2, z2);
            if (s1 > s2)
            {
                Console.WriteLine("Первый треугольник больше. Площадь = {0}", s1);
            }
            else if (s1 < s2)
            {
                Console.WriteLine("Второй треугольник больше. Площадь = {0}", s2);
            }
            else
            {
                Console.WriteLine("Треугольники равны. Площадь равна {0}", s1);
            }
            Console.ReadKey();
        }
        static double GetSquare(int x, int y, int z)
        {
            float p = (x + y + z) / 2;
            double s = Math.Sqrt(p * (p - x) * (p - y) * (p - z));

            return s;

        }
    }
}
