using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Utilites
{
    public class Number_1
    {
        public string n1(int n)
        {
            if (n < 1 || n > 26)
            {
                throw new ArgumentException();
            }
            return new string(Enumerable.Range('A', n).Select(c => (char)c).ToArray());
        }
        
    }
}
