using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task_12._2._1
{
    static class Circle
    {
        static public double GetLenght(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static public double GetArea(double radius)
        {
            return Math.PI * radius;
        }

        static public bool PointInCircle(double x, double y, double radius)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            return hypotenuse <= radius;
        }
    }
}
