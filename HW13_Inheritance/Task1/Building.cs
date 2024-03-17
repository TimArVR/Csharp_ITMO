using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Building
    {
        private string Adress { get; set; }
        private double _length;
        private double _width;
        private double _height;

        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                if (value > 0)
                {
                    _length = value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод длины");
                }

            }
        }
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                if (value > 0)
                {
                    _width = value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод ширины");
                }
            }
        }
        public double Height
        {
            get
            {
                return _height;
            }
            set
            {
                if (value > 0)
                {
                    _height = value;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод высоты");
                }
            }
        }
        public Building(string adr, double len, double wid, double hei)
        {
            Adress = adr;
            Length = len;
            Width = wid;
            Height = hei;
        }

        public string Print() 
        {
            return $"Адрес здания: {Adress}\nДлина здания: {_length}\nШирина здания: {_width}\nВысота здания: {_height}";
        }
    }
}
