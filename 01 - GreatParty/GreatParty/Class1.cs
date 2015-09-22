using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatParty
{
    public class Class1
    {
        public bool GreatParty(int cigars, bool isWeekend)
        {
            bool isPartyGreat = true;

            if (!isWeekend)
            {
                if (cigars >= 40 && cigars <= 60)
                {
                    isPartyGreat = true;
                }
                else
                {
                    isPartyGreat = false;
                }
            }
            else
            {
                if (cigars >= 40)
                {
                    isPartyGreat = true;
                }
                else
                {
                    isPartyGreat = false;
                }
            }

            return isPartyGreat;
        }
    }
}
