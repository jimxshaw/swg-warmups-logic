using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollDice
{
    public class Class1
    {
        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (noDoubles)
            {
                if (die1 == die2)
                {
                    if (die1 == 6)
                    {
                        die1 = 1;
                        return die1 + die2;
                    }

                    die1++;
                    return die1 + die2;
                }

                return die1 + die2;
            }

            return die1 + die2;
        }
    }
}
