using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, x4, y1, y2, y3, y4;
            Console.WriteLine("Введите координаты трёх точек в порядке: x1, y1, x2, y2, x3, y3");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            x4 = 0; y4 = 0;
            bool parall = true;

            if (x1 == x2)
            {
                x4 = x3;
            }
            else if (x1 == x3)
            {
                x4 = x2;
            }
            else if (x2 == x3)
            {
                x4 = x1;
            }
            else
            {
                parall = false;
            }

            if (y1 == y2)
            {
                y4 = y3;
            }
            else if (y1 == y3)
            {
                y4 = y2;
            }
            else if (y2 == y3)
            {
                y4 = y1;
            }
            else
            {
                parall = false;
            }
            
            if (parall) {
                Console.WriteLine("{0}, {1}", x1, y1);
                Console.WriteLine("{0}, {1}", x2, y2);
                Console.WriteLine("{0}, {1}", x3, y3);
                Console.WriteLine("{0}, {1}", x4, y4);
            }
            else
            {
                Console.WriteLine("Не параллельны");
            }
            Console.ReadKey();
        }
    }
}
