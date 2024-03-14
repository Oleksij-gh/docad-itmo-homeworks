using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string address;
            double lenght;
            double width;
            double height;
            int coutOfFloor;
            Console.WriteLine("Введите параметры здания.");
            Console.Write("Ардес: ");
            address = Console.ReadLine();
            Console.Write("Длина: ");
            lenght = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ширина: ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Высота: ");
            height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Количество этажей: ");
            coutOfFloor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            if (coutOfFloor == 0)
            {
                Building building = new Building(address, lenght, width, height);
                Console.WriteLine(building.Print());
            }
            else
            {
                MultiBuilding multiBuilding = new MultiBuilding(address, lenght, width, height, coutOfFloor);
                Console.WriteLine(multiBuilding.Print());
            }
            Console.ReadKey();
        }
    }
}
