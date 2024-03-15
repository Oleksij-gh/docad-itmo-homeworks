using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_20._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate myDelegate0 = new MyDelegate(GetLenght);
            MyDelegate myDelegate1 = new MyDelegate(GetArea);
            MyDelegate myDelegate2 = new MyDelegate(GetVolume);

            Console.WriteLine(myDelegate0(10));
            Console.WriteLine(myDelegate1(10));
            Console.WriteLine(myDelegate2(10));

            Console.ReadKey();
        }

        public delegate double MyDelegate(double value);

        public static double GetLenght(double radius) => 2 * Math.PI * radius;
        public static double GetArea(double radius) =>  2 * Math.PI* Math.Pow(radius, 2);
        public static double GetVolume(double radius) => 4 / 3 * Math.PI * Math.Pow(radius, 3);
    }
}
