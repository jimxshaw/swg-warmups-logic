using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaughtSpeeding
{
    public class Class1
    {
        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            int getTicket = 0;

            if (isBirthday)
            {
                if (speed >= 86)
                {
                    getTicket = 2;
                }
                else if (speed >= 66 && speed <= 85)
                {
                    getTicket = 1;
                }
                else
                {
                    getTicket = 0;
                }
            }
            else
            {
                if (speed >= 81)
                {
                    getTicket = 2;
                }
                else if (speed >= 61 && speed <= 80)
                {
                    getTicket = 1;
                }
                else
                {
                    getTicket = 0;
                }
            }

            return getTicket;
        }
    }
}
