using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? true or false");
            bool boolDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());
            Console.WriteLine("Qualified for car insurance?");
            bool qualified = age > 15 && !boolDUI && speedingTickets < 3;
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
