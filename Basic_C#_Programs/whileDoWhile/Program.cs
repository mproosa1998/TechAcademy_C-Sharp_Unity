using System;

namespace whileDoWhile
{
    class Program
    {
        static void Main()
        {
            bool escapeWhile = false;
            while (!escapeWhile)
            {
                do
                {
                    Console.WriteLine("To exit loop type: ENTER");
                    if (Console.ReadLine() == "ENTER")
                    {
                        escapeWhile = true;
                    }
                    else
                    {
                        Console.WriteLine("Loop Continuing");
                    }
                } while (!escapeWhile);
            }
        }
    }
}
