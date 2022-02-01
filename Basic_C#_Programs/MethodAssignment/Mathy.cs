using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Mathy
    {
        public void Add(int userInt)
        {
                int solution = userInt + userInt;
            Console.WriteLine(userInt + " Plus Itself Is " + solution);
        }
        public void Multiply(int userInt)
        {
                int solution = userInt * userInt;
                Console.WriteLine(userInt + " Times Itself Is " + solution);
        }

        public void Divide(int userInt)
        {
            int solution = userInt / userInt;
            Console.WriteLine(userInt + " Divided By Itself Is " + solution);
        }


    }

   
    
}
