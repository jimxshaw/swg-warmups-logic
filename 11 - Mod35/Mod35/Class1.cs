using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod35
{
    public class Class1
    {
        public bool Mod35(int n)
        {
            if (n%3 == 0 && n%5 == 0)
            {
                return false;
            }

            if (n%3 == 0 || n%5 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
