using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class Number_2
    {
        public double[] n2(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new ArgumentException();
            }
            double discriminant = b * b - 4 * a * c;
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                return new double[] { x1, x2 };
            }
            else if (discriminant == 0)
            {
                double x3 = -b / (2 * a);
                return new double[] { x3 };
            }
            else
            {
                return null;
            }
            
        }
    }
}
