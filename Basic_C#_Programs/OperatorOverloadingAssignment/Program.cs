using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { ID = 0001 };
            Employee employee2 = new Employee { ID = 0002 };
            Employee employee3 = new Employee { ID = 0001 };

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 == employee3);
            Console.ReadLine();
        }

    }
}
