using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Cat : Animal
    {
        //private string _voice;
        private string _catName;

        public override string AnimalName
        {
            get => _catName;
            set => _catName = value;
        }

        public Cat (string name/*,string voice*/)
            :base(name)
        {
        //_voice = voice;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
}
