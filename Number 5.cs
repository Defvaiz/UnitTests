using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class Number_5
    {
        public int n5(string numberString)
        {
            if (numberString == null)
            {
                throw new ArgumentNullException();
            }
            int sum = 0;
            foreach ( char c in numberString)
            {
                if (char.IsDigit(c))
                {
                    
                    sum += int.Parse(c.ToString());
                    
                }
                
            }
            return sum;
            

            
        }
    }
}
