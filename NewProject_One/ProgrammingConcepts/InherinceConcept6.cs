using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class InherinceConcept6
    {
        public InherinceConcept6()
        {
            Console.WriteLine("This is child class constructor");
        }
        public void I1()
        {
            Console.WriteLine("this is Child class method 1");
            int i = 10;
            int j = 20;
            int z = i + j;
            Console.WriteLine("The (Addition)value of z is :" + z);

        }
        public void I2()
        {
            Console.WriteLine("this is Child class method 2");
        }

    }
}
