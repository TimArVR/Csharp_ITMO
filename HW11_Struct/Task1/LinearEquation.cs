using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal struct LinearEquation
    {
        double _coefK;
        double _coefB;

        public LinearEquation(double k, double b)
        {
            this._coefK = k;
            this._coefB = b;
        }

        public string Root()
        {
            if (this._coefK == 0)
            {
                return "Коэффициент к не может быть равен нулю!";
            }
            else 
            {
                return $"Х равен: {-_coefB / _coefK}"; 
            }
        }
    }
}
