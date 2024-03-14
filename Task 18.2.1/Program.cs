using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_18._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool strIsOk = true;
            string str = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(')
                {
                    stack.Push(')');
                }
                else if (c == '{')
                {
                    stack.Push('}');
                }
                else if (c == '[')
                {
                    stack.Push(']');
                }
                else
                {
                    if (stack.Count == 0 || c != stack.Pop())
                    {
                        strIsOk = false;
                        break;
                    }

                }
            }

            if (strIsOk && stack.Count == 0)
            {
                Console.WriteLine("Корректно");
            }
            else
            {
                Console.WriteLine("Некорректно");
            }

            Console.ReadKey();
        }
    }
}
