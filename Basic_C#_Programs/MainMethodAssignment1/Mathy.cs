using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodAssignment1
{
    class Mathy
    {
        public static int letsMath(int integer)
        {
            return integer + integer;
        }
        public static int letsMath(decimal deceger)
        {
            return Convert.ToInt32(50/deceger);
        }
        public static int letsMath(string strinteger)
        {
            return 10 * Convert.ToInt32(strinteger);
        }
    }
}
