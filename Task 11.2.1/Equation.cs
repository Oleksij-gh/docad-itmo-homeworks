using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._2._1
{
    internal struct Equation
    {
        double k;
        double b;

        public Equation(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        
        public string Root()
        {
            if (k == 0)
            {
                return "Решений нет";
            }
            else
            {
                return $"Решение уравнения: x = {-b / k}";
            }
        }
    }
}
