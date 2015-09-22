using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkipSum
{
    public class Class1
    {
        public int SkipSum(int a, int b)
        {
            int sum = a + b;

            if (sum >= 10 && sum <= 19)
            {
                sum = 20;
            }

            return sum;
        }
    }
}
