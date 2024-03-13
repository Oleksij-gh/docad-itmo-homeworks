using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, R;
            Console.WriteLine("Введите координаты точки (x, y) и радиус окружности R.");
            Console.Write("x = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y = ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("R = ");
            R = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Длина окружности: {Circle.Lenght(R)}\nПлощадь окружности: {Circle.Square(R)}");

            if (Circle.PointInCircle(x, y, R)){
                Console.WriteLine("Точка находится в окружности.");
            }
            else
            {
                Console.WriteLine("Точка находится вне окружности.");
            }
            Console.ReadKey();


        }
    }
}
