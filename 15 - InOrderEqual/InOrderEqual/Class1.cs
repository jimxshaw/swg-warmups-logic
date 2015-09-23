using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOrderEqual
{
    public class Class1
    {
        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (equalOk)
            {
                if (a <= b && b <= c)
                {
                    return true;
                }

                return false;
            }

            if (a < b && b < c)
            {
                return true;
            }

            return false;
        }
    }
}
