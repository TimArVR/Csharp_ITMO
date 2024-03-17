using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract internal class Animal
    {
        abstract public string AnimalName { get; set; }

        public Animal(string name) 
        {
            AnimalName = name; 
        }

        abstract public void Say();
        public void ShowInfo() 
        {
            Console.WriteLine(AnimalName);
            Say();
        }
    }
}
