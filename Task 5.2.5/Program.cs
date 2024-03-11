using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число N");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int [N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if((i%2 == 0 && j%2 == 0) || (i % 2 == 1 && j % 2 == 1))
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
