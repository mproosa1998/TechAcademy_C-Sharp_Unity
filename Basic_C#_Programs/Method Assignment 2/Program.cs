using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first integer:");
            int One = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second integer or press ENTER:");
            string input = Console.ReadLine();
            if (input != "")
            {
                int Two = Convert.ToInt32(input);
                OneOrTwo.OneOrTwoWhat(One, Two);
            }
            else
            {
                OneOrTwo.OneOrTwoWhat(One);
            }
            Console.ReadLine();
        }
    }
}
