using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialEleven
{
    public class Class1
    {
        public bool SpecialEleven(int n)
        {
            if (n%11 == 0 || ((n - 1)%11 == 0))
            {
                return true;
            }

            return false;
        }
    }
}
