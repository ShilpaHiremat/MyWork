using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    internal class ReturnTypeMethodConceptThree
    {
        public int m1(int i, int j)
        {
            Console.WriteLine("Return Type Method");
            int z = i + j;
            Console.WriteLine("The sum value is:" + z);
            return z;

        }

        public static void s1()
        {
            Console.WriteLine("This is statis method");
            ReturnTypeMethodConceptThree obj1 = new ReturnTypeMethodConceptThree();
           int z =obj1.m1(10, 20);
            Console.WriteLine("The Final value is:" + z); 

        }
    }
}
