using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    internal class InheritanceConceptMethodOverridding7 : InherinceConcept6
    {
        //For Methodoverriding, in child class same method name should be there, then only it overrides 
        //methods of parent class and it displays methods of child class. 
        public InheritanceConceptMethodOverridding7()
        {
            Console.WriteLine("This is child class constructor");
        }
        public void I1()
        {
            Console.WriteLine("this is Child class method 1");
            int i = 10;
            int j = 3;
            int z = i + j;
            Console.WriteLine("The (Addition)value of z is :" + z);
        }
        public void I2()
        {
            Console.WriteLine("this is Child class method 2");
        }
    }
    

    
}
