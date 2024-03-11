using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year;
            int first;
            int second;
            Console.WriteLine("Введите желаемое числов диапазоне 20-69");
            year = Convert.ToInt32(Console.ReadLine());
            first = year / 10;
            second = year % 10;

            switch (first)
            {
                case 2:
                    Console.Write("Двадцать ");
                    break;
                case 3:
                    Console.Write("Тридцать ");
                    break;
                case 4:
                    Console.Write("Сорок ");
                    break;
                case 5:
                    Console.Write("Пятьдесят ");
                    break;
                case 6:
                    Console.Write("Шестьдесят ");
                    break;
                default:
                    Console.WriteLine("Ошибка. Введено неверное число");
                    break;
            }
            switch (second)
            {
                
                case 1:
                    Console.Write("один год");
                    break;
                case 2:
                case 3:
                case 4:
                    switch (second)
                    {
                        case 2:
                            Console.Write("два ");
                            break;
                        case 3:
                            Console.Write("три ");
                            break;
                        case 4:
                            Console.Write("четыре ");
                            break;
                    }
                    Console.Write("года");
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 0:
                    switch (second)
                    {
                        case 5:
                            Console.Write("пять ");
                            break;
                        case 6:
                            Console.Write("шесть ");
                            break;
                        case 7:
                            Console.Write("семь ");
                            break;
                        case 8:
                            Console.Write("восемь ");
                            break;
                        case 9:
                            Console.Write("девять ");
                            break;
                    }
                    Console.Write("лет");
                    break;

                default:
                    Console.WriteLine("Ошибка. Введено неверное число");
                    break;
            }
            Console.ReadKey();

        }
    }
}
