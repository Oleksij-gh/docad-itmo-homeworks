using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13._2._1
{
    internal sealed class MultiBuilding : Building
    {
        int countOfFloors;

        int CountOfFloors
        {
            get { return countOfFloors; }
            set { countOfFloors = value; }
        }
        public MultiBuilding(string address, double lenght, double width, double height, int countOfFloors)
            : base(address, lenght, width, height)
        {
            CountOfFloors = countOfFloors;
        }

        public string Print()
        {
            return base.Print() + $"Количество этажей в доме: {CountOfFloors}\n";
        }
    }
}
