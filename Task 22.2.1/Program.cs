using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_22._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Введите размер массива: ");
            n = Convert.ToInt32(Console.ReadLine());

            Func<object, int[]> func1 = new Func<object, int[]>(GetArray);
            Task<int[]> task1 = new Task<int[]>(func1, n);

            Func<Task<int[]>, int> func2 = new Func<Task<int[]>, int>(GetMaximum);
            Task<int> task2 = task1.ContinueWith<int>(func2);

            Func<Task<int[]>, int> func3 = new Func<Task<int[]>, int>(GetSum);
            Task<int> task3 = task1.ContinueWith<int>(func3);

            task1.Start();

            Console.WriteLine($"Максимум: {task2.Result}");
            Console.WriteLine($"Сумма: {task3.Result}");

            Console.ReadKey();


        }

        static int[] GetArray(object a)
        {
            int n = (int)a;
            Random rnd = new Random();
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = rnd.Next(0, 100);
            }

            return array;
        }

        static int GetMaximum(Task<int[]> task)
        {
            int[] array = task.Result;
            int max = array[0];
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int GetSum(Task<int[]> task)
        {
            int[] array = task.Result;
            int sum = 0;
            for (int i = 0; i < array.Count(); i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}
