using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal static class Circle
    {
        static public double GetCircleLength(double r)
        {
            return 2 * Math.PI * r;
        }

        static public double GetCircleArea(double r)
        {
            return Math.PI * r * r;
        }

        static public bool GetPointBelongsToCircle(double r, double x,double y)
        {
            double hypotenuse = Math.Sqrt(x * x + y * y);
            if (r>=hypotenuse)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
