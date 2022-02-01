using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Enter a number to divide by:");
            
            try
            {
                double dividend = Convert.ToDouble(Console.ReadLine());
                if(dividend != 0)
                {
                    foreach(int number in numbers)
                    {
                        Console.WriteLine(number + " \u00f7 " + dividend + " = " + (number / dividend));
                    }
                }
                else
                {
                    Console.WriteLine(1 / Convert.ToInt32(dividend));
                }
                
            }
            catch(FormatException)
            {
                Console.WriteLine("User Input Was Not A Number");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot Divide By Zero");
            }
            Console.WriteLine("Exited TRY/CATCH Code");
            Console.ReadLine();
        }
    }
}
