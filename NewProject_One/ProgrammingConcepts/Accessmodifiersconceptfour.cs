using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class Accessmodifiersconceptfour
    {
        public Accessmodifiersconceptfour()
        {
            Console.WriteLine("Parent class constructor");
        }
        public void I1(int i, int j)
        {
            Console.WriteLine("This is parent class method");
            Console.WriteLine("The value of i" + i);
            Console.WriteLine("The value of j" + j);
            I3();
        }
        protected void I2()
        {
            //protected can be accessed within the same class and in inherit class
            Console.WriteLine("Parent class Protected method");
        }
        private void I3()
        {
            //private can be accessed only within the same class
            Console.WriteLine("Parent class Private method");
        }

    }
}
