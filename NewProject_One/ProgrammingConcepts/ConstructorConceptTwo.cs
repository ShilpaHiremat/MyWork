using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    internal class ConstructorConceptTwo
    {
        int x;
        int y;
        int s;
        int z;
        public ConstructorConceptTwo (int a, int b)
        {
            Console.WriteLine("This is Parameterizsed Constructor");
            int i = 10;
            int j = 20;
            z = i + j; 
            Console.WriteLine("The sum of values is " + z);
            x = a;
            y = b; 

        }
        public ConstructorConceptTwo()
        {
            Console.WriteLine("This is Constructor without parameter");
        }
        public ConstructorConceptTwo(int s)
        {
            Console.WriteLine("This is Constructor with 1 parameter");
            this.s = s;
        }

        //Instance Method
        public void I1()
        {
            Console.WriteLine(" The value of x is" + x);
            Console.WriteLine("The valus of y is" + y);

        }
        public void I2()
        {
            Console.WriteLine(" The value of s is" + s);
        }
        public void I3()
        {
            Console.WriteLine("This Instance method of Concept2 class");
        }
        public static void s1()
        {
            Console.WriteLine("This static method of Concept2 class");
        }


    }
}
