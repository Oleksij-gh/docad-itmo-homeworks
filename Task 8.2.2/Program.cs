using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_8._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "temp";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            string pathFile = path + "/temp.txt";
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }

            StreamWriter writer = new StreamWriter(pathFile);
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                writer.Write("{0} ", random.Next(0, 20));
            }
            writer.Close();

            StreamReader reader = new StreamReader(pathFile);
            object[] array = new object[10];
            string str = reader.ReadToEnd();
            reader.Close();
            str = str.Trim(' ');
            string[] strArray = str.Split(' ');
            long s = 0;
            foreach (string numberStr in strArray)
            {
                int number = Convert.ToInt32(numberStr);
                s += number;
            }
            Console.WriteLine("Сумма чиcел: {0}", s);
            Console.ReadKey();
        }
    }
}
