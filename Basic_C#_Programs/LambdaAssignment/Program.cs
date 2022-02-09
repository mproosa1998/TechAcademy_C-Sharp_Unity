using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { FirstName = "Joe", LastName = "Smith", ID = 0001 });
            employees.Add(new Employee { FirstName = "Will", LastName = "Smith", ID = 0002 });
            employees.Add(new Employee { FirstName = "Joe", LastName = "Mama", ID = 0003 });
            employees.Add(new Employee { FirstName = "Tim", LastName = "Doe", ID = 0004 });
            employees.Add(new Employee { FirstName = "Joan", LastName = "Orleans", ID = 0005 });
            employees.Add(new Employee { FirstName = "Keanu", LastName = "Reeves", ID = 0006 });
            employees.Add(new Employee { FirstName = "Commander", LastName = "Shepard", ID = 0007 });
            employees.Add(new Employee { FirstName = "Gearlt", LastName = "Rivia", ID = 0008 });
            employees.Add(new Employee { FirstName = "Cloud", LastName = "Strife", ID = 0009 });
            employees.Add(new Employee { FirstName = "Tim", LastName = "Drake", ID = 0010 });
            employees.Add(new Employee { FirstName = "John", LastName = "Williams", ID = 0011 });


            List<Employee> employees1 = new List<Employee>();
            foreach(Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    employees1.Add(employee);
                }

            }
            foreach (Employee employee1 in employees1)
            {
                Console.WriteLine(employee1.LastName);
            }
            Console.WriteLine();

            List<Employee> employees2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee employee2 in employees2)
            {
                Console.WriteLine(employee2.LastName);
            }
            Console.WriteLine();

            List<Employee> employees3 = employees.Where(x => x.ID > 5).ToList();

            foreach(Employee employee3 in employees3)
            {
                Console.WriteLine(employee3.LastName);
            }

            Console.ReadLine();
        }

    }
}
