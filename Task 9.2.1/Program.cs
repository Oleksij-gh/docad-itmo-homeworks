using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_9._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long x, y;
            byte operation;
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число X = ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.Write("Введите целое число Y = ");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Введите номер желаемой операции:\n 1 - сложение\n 2 - вычитание\n 3 - произведение\n 4 - частное");
                Console.Write("Номер операции: ");
                operation = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка во время присвоения переменных");
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return;
            }

            switch (operation)
            {
                case 1:
                    {
                        Console.WriteLine("Результат операции: {0}", x + y);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Результат операции: {0}", x - y);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Результат операции: {0}", x * y);
                        break;
                    }
                case 4:
                    {
                        try
                        {
                            Console.WriteLine("Результат операции: {0}", x / y);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            Console.ReadKey();
                            break;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Операция с указанным номером отсутствует.");
                        break;
                    }

            }
            Console.ReadKey();

        }
    }
}
