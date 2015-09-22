using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CanHazTable
{
    public class Class1
    {
        public int CanHazTable(int yourStyle, int dateStyle)
        {
            int getTable = 0;

            if (yourStyle >= 8 || dateStyle >= 8)
            {
                if (yourStyle <= 2 || dateStyle <= 2)
                {
                    getTable = 0;
                }
                else
                {
                    getTable = 2;
                }
            }
            else if ((yourStyle > 2 && yourStyle < 8) && (dateStyle > 2 && dateStyle < 8))
            {
                getTable = 1;
            }

            return getTable;
        }
    }
}
