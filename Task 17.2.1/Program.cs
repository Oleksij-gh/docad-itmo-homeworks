using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount<int> bankAccountInt = new BankAccount<int>();
            bankAccountInt.InputInfo();
            Console.WriteLine(bankAccountInt.GetInfo());
            Console.WriteLine();

            BankAccount<string> bankAccountString = new BankAccount<string>();
            bankAccountString.InputInfo();
            Console.WriteLine(bankAccountString.GetInfo());
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
