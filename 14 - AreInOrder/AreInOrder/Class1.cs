using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreInOrder
{
    public class Class1
    {
        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (bOk)
            {
                if (c > b)
                {
                    return true;
                }

                return false;
            }

            if (b > a && c > b)
            {
                return true;
            }

            return false;
        }
    }
}
