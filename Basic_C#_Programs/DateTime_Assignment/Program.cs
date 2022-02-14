using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("How many hours do you want to jump?");
            int timespan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(DateTime.Now.AddHours(timespan));

            Console.Read();
        }
    }
}
