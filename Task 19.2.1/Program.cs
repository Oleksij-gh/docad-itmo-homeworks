using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_19._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Computer> computers = new List<Computer>()
            {
                new Computer(){
                    Code = "0123ABC",  ManufacturerName = "Asus",  ProcessorType = "Intel",
                    ProcessorRate = 4.2,  AmountRAM = 8192,  AmountSpace = 1024,
                    AmountVRAM = 4096,  Price = 50499,  Count = 3},
                new Computer(){
                    Code = "0153DEC",  ManufacturerName = "MSI",  ProcessorType = "AMD",
                    ProcessorRate = 4.2,  AmountRAM = 4096,  AmountSpace = 4096,
                    AmountVRAM = 8192,  Price = 50000,  Count = 10},
                new Computer(){
                    Code = "2153BTY",  ManufacturerName = "Asus",  ProcessorType = "AMD",
                    ProcessorRate = 2.4,  AmountRAM = 2048,  AmountSpace = 2048,
                    AmountVRAM = 4096,  Price = 60000,  Count = 25},
                new Computer(){
                    Code = "6113HBD",  ManufacturerName = "MSI",  ProcessorType = "Intel",
                    ProcessorRate = 3.3,  AmountRAM = 8192,  AmountSpace = 1024,
                    AmountVRAM = 8192,  Price = 50500,  Count = 30},
                new Computer(){
                    Code = "9423HDD",  ManufacturerName = "Lenovo",  ProcessorType = "Intel",
                    ProcessorRate = 4.2,  AmountRAM = 4096,  AmountSpace = 2048,
                    AmountVRAM = 2048,  Price = 20000,  Count = 7},
                new Computer(){
                    Code = "001AAA",  ManufacturerName = "Acer",  ProcessorType = "AMD",
                    ProcessorRate = 4.4,  AmountRAM = 2048,  AmountSpace = 512,
                    AmountVRAM = 4096,  Price = 80000,  Count = 9},
            };
            string manufacturer;
            Console.WriteLine("Введите название искомого производителя: ");
            manufacturer = Console.ReadLine();

            List<Computer> computerList0 = computers.Where(x => x.ManufacturerName == manufacturer).ToList();
            Print(computerList0);

            int ram;
            Console.WriteLine("Введите минимальный объем ОЗУ: ");
            ram = Convert.ToInt32(Console.ReadLine());

            List<Computer> computerList1 = computers.Where(x => x.AmountRAM >= ram).ToList();
            Print(computerList1);

            Console.WriteLine("Отсортированно по цене");
            List<Computer> computerList2 = computers.OrderBy(x => x.Price).ToList();
            Print(computerList2);

            Console.WriteLine("Сгруппированы по типу процессора");
            IEnumerable<IGrouping<string, Computer>> computerList3 = computers.GroupBy(x => x.ProcessorType);
            Print(computerList1);
            foreach (IGrouping<string, Computer> group in computerList3)
            {
                Console.WriteLine(group.Key);
                foreach (Computer computer in group)
                {
                    Console.WriteLine($"" +
                        $"{computer.Code} {computer.ManufacturerName} {computer.ProcessorType}" +
                        $" {computer.ProcessorRate} {computer.AmountRAM} {computer.AmountSpace}" +
                        $" {computer.AmountVRAM} {computer.Price} {computer.Count}"
                    );
                }
            }
            Console.WriteLine();

            Console.WriteLine("Максимальная и минимальная стоимости");
            List<Computer> computerList4 = new List<Computer>{
                computers.OrderBy(x => x.Price).FirstOrDefault(),
                computers.OrderBy(x => x.Price).LastOrDefault(),
            };
            Print(computerList4);

            Console.WriteLine("Есть ли хотя бы один компьютер в количестве не менее 30 штук?");
            Console.WriteLine(computers.Any(x => x.Count >= 30));

            Console.ReadKey();
        }


        static void Print(List<Computer> computers)
        {
            foreach (Computer computer in computers)
            {
                Console.WriteLine($"" +
                    $"{computer.Code} {computer.ManufacturerName} {computer.ProcessorType}" +
                    $" {computer.ProcessorRate} {computer.AmountRAM} {computer.AmountSpace}" +
                    $" {computer.AmountVRAM} {computer.Price} {computer.Count}"
                );
            }
            Console.WriteLine();

        }
    }
}
