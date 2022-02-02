using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAgain newMath = new MathAgain();
            Console.WriteLine("Enter Integer:");
            int One = Convert.ToInt32(Console.ReadLine());
            newMath.mathy(One);
            int answer;
            MathAgain.mathy(3,out answer,2);
            Console.WriteLine(answer);

            Console.Read();
        }
    }
}
