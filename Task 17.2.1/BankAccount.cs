using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17._2._1
{
    internal class BankAccount<T>
    {
        public T AccountNumber { get; set; }
        public double Balance { get; set; }
        public string Fio { get; set; }


        public string GetInfo()
        {
            return $"Номер аккаунта: {AccountNumber}\nФИО владельца: {Fio}\nБаланс: {Balance}";
        }

        public void InputInfo()
        {
            Console.Write("Введите номер аккаунта: ");
            AccountNumber = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.Write("Введите баланс аккаунта: ");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ФИО владельца аккаунта: ");
            Fio = Console.ReadLine();
            Console.WriteLine();
        }
    }
}
