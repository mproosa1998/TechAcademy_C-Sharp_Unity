using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class MathAgain
    {
        public void mathy(int One)
        {
            Console.WriteLine(One / 2);
        }

        public static void mathy(int One, out int Solution, int Two = 2)
        {
            Solution = One / Two;
        }


    }
}
