using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_15._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start, step, count;

            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();

            Console.Write("Введите начало прогрессии: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите шаг прогрессии: ");
            step = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите необходимое количество элементов: ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            arithProgression.SetStart(start);
            arithProgression.SetStep(step);

            Console.WriteLine("Арифметическая прогрессия.");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{arithProgression.GetNext()} ");
            }

            Console.WriteLine();

            geomProgression.SetStart(start);
            geomProgression.SetStep(step);
            Console.WriteLine("Геометрическая прогрессия.");
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{geomProgression.GetNext()} ");
            }
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
