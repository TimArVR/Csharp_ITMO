using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Dog:Animal
    {

        //private string _voice;
        private string _dogName;

        public override string AnimalName
        {
            get => _dogName;
            set => _dogName = value;
        }

        public Dog(string name/*, string voice*/)
            : base(name)
        {
            //_voice = voice;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }

    }
}
