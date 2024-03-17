using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    sealed internal class MultiBuilding : Building
    {
        private int _level;

        public int Level
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }

        public MultiBuilding(string adr, double len, double wid, double hei, int lev)
            : base(adr, len, wid, hei)
        {
            Level = lev;
        }

        public string Print() //Либо new в дочке либо vitual в родителе можно пофиксить варнинг
        {
            string result = base.Print();
            result += $"\nЭтаж: {_level}";
            return result;
        }
    }
}
