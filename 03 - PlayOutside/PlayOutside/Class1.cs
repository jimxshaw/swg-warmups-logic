using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayOutside
{
    public class Class1
    {
        public bool PlayOutside(int temp, bool isSummer)
        {
            bool playOutside = false;

            if (isSummer)
            {
                if (temp >= 60 && temp <= 100)
                {
                    playOutside = true;
                }
                else
                {
                    playOutside = false;
                }
            }
            else
            {
                if (temp >= 60 && temp <= 90)
                {
                    playOutside = true;
                }
                else
                {
                    playOutside = false;
                }
            }

            return playOutside;
        }
    }
}
