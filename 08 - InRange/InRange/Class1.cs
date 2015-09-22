using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRange
{
    public class Class1
    {
        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n <= 1 || n >= 10)
                {
                    return true;
                }

                return false;
            }
            else
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
