using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._2._1
{
    internal class Building
    {
        string address;
        double lenght;
        double width;
        double height;

        public string Address { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        
        public Building(string address, double lenght, double width, double height) 
        {
            Address = address;
            Lenght = lenght;
            Width = width;
            Height = height;
        
        }

        public string Print()
        {
            return $"Здание находится по адресу: {Address}\nДлина здания: {Lenght}\n" +
                $"Ширина здания: {Width}\nВысота здания :{Height}\n";
        }
    }
}
