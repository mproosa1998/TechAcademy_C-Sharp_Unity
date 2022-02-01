using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathy mathy = new Mathy();

            Console.WriteLine("Enter an Integer to run some basic math:");
            int userInt = Convert.ToInt32(Console.ReadLine());

            mathy.Add(userInt);
            mathy.Multiply(userInt);
            mathy.Divide(userInt);
            Console.ReadLine();


        }
    }
}
