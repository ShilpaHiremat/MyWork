using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    internal class AccessmodifiersandInheritnceConcept5 : Accessmodifiersconceptfour
    {
        public AccessmodifiersandInheritnceConcept5()
        {
            Console.WriteLine("This is Child class constructor");
        }
        public void I4()
        {
            Console.WriteLine("This is Child class method");
            I1(10, 10);
            I2();

        }

    }
}
