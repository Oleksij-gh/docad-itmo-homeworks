using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strSource = Console.ReadLine();
            string strRedacted = strSource.ToLower();
            strRedacted = strRedacted.Replace(" ", "");
            int strLen = strRedacted.Length;
            bool isPalindrome = true;
            for (int i = 0; i < strLen / 2; i++)
            {
                if (strRedacted[i] != strRedacted[strLen - i - 1])
                {
                    isPalindrome = false;
                    Console.WriteLine("Строка не является палиндромом.");
                    break;
                }
            }
            if (isPalindrome)
            {
                Console.WriteLine("Строка является палиндромом.");
            }
            Console.ReadKey();
        }
    }
}
