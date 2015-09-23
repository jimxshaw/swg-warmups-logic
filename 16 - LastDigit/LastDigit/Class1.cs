using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastDigit
{
    public class Class1
    {
        public bool LastDigit(int a, int b, int c)
        {
            string stringA = a.ToString();
            string stringB = b.ToString();
            string stringC = c.ToString();

            if (stringA.Substring(stringA.Length - 1) == stringB.Substring(stringB.Length - 1) ||
                stringA.Substring(stringA.Length - 1) == stringC.Substring(stringC.Length - 1) ||
                stringB.Substring(stringB.Length - 1) == stringC.Substring(stringC.Length - 1))
            {
                return true;
            }

            return false;
        }
    }
}
