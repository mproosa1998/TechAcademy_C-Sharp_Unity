using System;

namespace DailyReportSubmissionAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report.\n");
            Console.WriteLine("What is your name?");
            String studentName = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            String currentCourse = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            bool needsHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Were there any positive experiences you\'d like to share? Please give specifics.");
            String positiveExperience = Console.ReadLine();
            Console.WriteLine("Is ther any other feed back you\'d like to provide? Please be specific.");
            String Other = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            decimal hoursStudied = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
