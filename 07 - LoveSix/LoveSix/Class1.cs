using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveSix
{
    public class Class1
    {
        public bool LoveSix(int a, int b)
        {
            if (a == 6 || b == 6)
            {
                return true;
            }

            if (a + b == 6)
            {
                return true;
            }

            if (a - b == 6 || b - a == 6)
            {
                return true;
            }

            return false;
        }
    }
}
