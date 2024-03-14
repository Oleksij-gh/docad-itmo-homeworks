using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14._2._1
{
    internal class Cat : Animal
    {
        private string name;
        private const string sound = "Мяу";
        public override string Name
        {
            get => name;
            set => name = value;
        }

        public Cat(string name)
            : base(name) { }

        public override void Say()
        {
            Console.WriteLine(sound); ;
        }
    }
}
