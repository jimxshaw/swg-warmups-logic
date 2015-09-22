using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerCell
{
    public class Class1
    {
        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }

            if (isMorning)
            {
                if (isMom)
                {
                    return true;
                }

                return false;
            }

            return true;
        }
    }
}
