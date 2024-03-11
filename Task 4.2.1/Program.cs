using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            long square = 0;
            Console.WriteLine("Введите число, для которого необходимо вычислить квадрат");
            N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < N + 1; i++)
            {
                square += 2 * i - 1;
            }
            Console.WriteLine("Квадрат числа {0} = {1}", N, square);
            Console.ReadKey();
        }
    }
}
