using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14._2._1
{
    internal class Dog : Animal
    {
        private string name;
        private const string sound = "Гав";
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Dog(string name)
            : base(name) { }

        public override void Say()
        {
            Console.WriteLine(sound); ;
        }
    }
}
