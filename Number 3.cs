using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Utilites
{
    public class Number_3
    {
       
        public bool n3(int year)
        {
            if (year <= 0)
                throw new ArgumentException();
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return year % 400 == 0;
                }
                return true;
            }
            return false;
        }
    }
}
