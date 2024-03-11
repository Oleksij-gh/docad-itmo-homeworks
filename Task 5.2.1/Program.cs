using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 7;
            int t;
            float s = 0;
            int[] array = new int[n];

            Console.WriteLine("Последовательно введите 7 элементов массива.");
            for (int i = 0; i < n; i++)
            {
                t = Convert.ToInt32(Console.ReadLine());
                s += t;
                array[i] = t;
            }
            Console.Write("Для массива из элементов: ");
            foreach (int i in array)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("среднее арифметическое = {0}", s / n);
            Console.ReadKey();

        }
    }
}
