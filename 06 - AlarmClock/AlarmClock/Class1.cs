using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClock
{
    public class Class1
    {
        public string AlarmClock(int day, bool vacation)
        {
            string time = "off";

            if (vacation)
            {
                if (day >= 1 && day <= 5)
                {
                    time = "10:00";
                }
                else
                {
                    time = "off";
                }
            }
            else
            {
                if (day >= 1 && day <= 5)
                {
                    time = "7:00";
                }
                else
                {
                    time = "10:00";
                }
            }

            return time;
        }
    }
}
