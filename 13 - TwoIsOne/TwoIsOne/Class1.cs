using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIsOne
{
    public class Class1
    {
        public bool TwoIsOne(int a, int b, int c)
        {
            if ((a + b == c) || (a + c == b) || (b + c == a))
            {
                return true;
            }

            return false;
        }
    }
}
