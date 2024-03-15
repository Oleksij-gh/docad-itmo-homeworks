using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_21._2._1
{
    internal class Program
    {
        const int n = 5;
        // # - участок обработал 1 садовник
        // @ - учаток обработал 2 садовник
        // изначально все участки пустые ' ' - необработанные
        static char[,] garden = new char[n, n] 
        { 
            { ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ' },
            { ' ', ' ', ' ', ' ', ' ' },
        };

        // числа - сколько времени потребуется садовнику на обработку участка
        static int[,] plan = new int[n, n]
        {
            { 0, 5, 0, 10, 0 },
            { 1, 3, 0, 1, 32 },
            { 0, 0, 1, 0, 0 },
            { 1, 7, 0, 19, 14 },
            { 0, 43, 0, 15, 0 },
        };



        static void Main(string[] args)
        {
            ThreadStart threadStart = new ThreadStart(Gardener2);
            Thread thread = new Thread(threadStart);
            thread.Start();

            Gardener1();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(garden[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }

        static void Gardener1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (garden[i, j] == ' ' && plan[i, j] != 0)
                    {
                        garden[i, j] = '#';
                        Thread.Sleep(plan[i, j]);
                    }
                }
            }
        }

        static void Gardener2()
        {
            for (int j = n-1; j >= 0; j--)
            {
                for (int i = n-1; i >= 0; i--)
                {
                    if (garden[i, j] == ' ' && plan[i, j] != 0)
                    {
                        garden[i, j] = '@';
                        Thread.Sleep(plan[i, j]);
                    }
                }
            }
        }
    }
}
