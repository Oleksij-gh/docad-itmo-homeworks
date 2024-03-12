using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_8._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Пример для дирректории проекта
            //string path = Directory.GetCurrentDirectory();
            string path = "C:\\study\\stat";
            GetFiles(path);
            Console.ReadKey();



        }

        static void GetFiles(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            DirectoryInfo[] subDirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();
            Console.WriteLine("dir: {0}", dir.FullName);
            foreach (FileInfo file in files)
            {
                Console.WriteLine("---file: {0}",file.FullName);
            }
            foreach (DirectoryInfo subDir in subDirs)
            {
                GetFiles(subDir.FullName);
            }
        }
    }
}
