using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod20
{
    public class Class1
    {
        public bool Mod20(int n)
        {
            if (((n - 1)%20 == 0) || ((n - 2)%20 == 0))
            {
                return true;
            }

            return false;
        }
    }
}
