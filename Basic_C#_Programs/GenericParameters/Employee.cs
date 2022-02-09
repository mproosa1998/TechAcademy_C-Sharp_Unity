using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameters
{
    class Employee <Type>
    {
        public List<Type> Things = new List<Type> { };

        public void spill()
        {
            foreach(Type thing in Things)
            {
                Console.WriteLine(thing);
            }
        }

    }
}
