using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны куба.");
            int x = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetSquareVolume(x, out S, out V);

            Console.WriteLine("Площадь равна {0}, объем равен {1}", S, V);
            Console.ReadKey();
        }

        static void GetSquareVolume(int x, out double S,  out double V)
        {
            S = 6 * (x * x);
            V = x * x * x;
        }
    }
}
