using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double k, b;
            Console.WriteLine("Для уравнения вида 0 = kx + b");
            Console.Write("Введите коэффициент k = ");
            k = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите коэффициент b = ");
            b = Convert.ToDouble(Console.ReadLine());

            Equation equation = new Equation(k, b);
            Console.WriteLine(equation.Root()); 
            Console.ReadKey();


        }
    }
}
