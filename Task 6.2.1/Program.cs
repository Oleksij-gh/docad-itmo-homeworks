using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringSource = Console.ReadLine();
            string[] stringArray = stringSource.Split(' ');
            string maxLenString = "";
            foreach (string str in stringArray)
            {
                if (str.Length > maxLenString.Length)
                {
                    maxLenString = str;
                }
            }

            Console.WriteLine(maxLenString);
            Console.ReadKey();
        }
    }
}
