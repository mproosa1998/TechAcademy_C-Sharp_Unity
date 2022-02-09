using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        enum Day { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};
        static void Main(string[] args)
        {
            Console.WriteLine("What Day of the Week is it?");
            bool finished = false;
            while(!finished)
            try
            {
                Day day = (Day)Enum.Parse(typeof(Day), Console.ReadLine());
                Console.WriteLine(day);
                finished = true;
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");

            }
            Console.ReadLine();
            
        }
    }
}
