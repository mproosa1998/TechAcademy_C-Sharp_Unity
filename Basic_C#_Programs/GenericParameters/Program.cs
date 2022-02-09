using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.Things.Add("Hello");
            employee.Things.Add("World");
            employee.spill();
            Employee<int> employee1 = new Employee<int>();
            employee1.Things.Add(1);
            employee1.Things.Add(2);
            employee1.spill();
            Console.ReadLine();
        }
    }
}
