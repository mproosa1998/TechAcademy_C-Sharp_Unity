using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingAssignment
{
    class Employee
    {
        public int ID;

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return (employee1.ID == employee2.ID) ;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return (employee1.ID != employee2.ID);
        }
    }
}
