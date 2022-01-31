using System;

namespace AnonymousIncomeCompariosonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate: ");
            float person1HourlyRate = float.Parse(Console.ReadLine());
            Console.Write("Hours Worked Per Week: ");
            float person1HoursWorked = float.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.Write("Hourly Rate: ");
            float person2HourlyRate = float.Parse(Console.ReadLine());
            Console.Write("Hours Worked Per Week: ");
            float person2HoursWorked = float.Parse(Console.ReadLine());

            float weeksWorked = 50;
            float Salary1 = person1HourlyRate * person1HoursWorked * weeksWorked;
            float Salary2 = person2HourlyRate * person2HoursWorked * weeksWorked;
            bool person1_GreaterThan_person2 = Salary1 > Salary2;

            Console.WriteLine("Annual Salary of Person 1: " + Salary1);
            Console.WriteLine("Annual Salary of Person 2: " + Salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(person1_GreaterThan_person2);
            Console.Read();
        }
    }
}
