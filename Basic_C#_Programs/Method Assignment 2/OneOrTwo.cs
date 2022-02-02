using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_2
{
    class OneOrTwo
    {
        public static void OneOrTwoWhat(int One, int Two = 2)
        {
            
            Console.WriteLine(One * Two);
        }
    }
}
