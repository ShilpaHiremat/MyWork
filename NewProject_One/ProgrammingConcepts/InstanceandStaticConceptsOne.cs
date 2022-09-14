using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class InstanceandStaticConceptsOne
    {
        //Instance Variables: Need to create an object if we want to access the instance variable/methods
        //in static methods/variables. 

        int i = 10;
        int j = 20;

        //Static Variables: No need to create an object if we want to access the static variable/methods
        //in Instance methods/variables. 
        static int k = 30;
        static int y = 40;

        public void I1()
        {
            Console.WriteLine("This is an Instance Method 1:");
            int sum1 = i + j; // local variable
            int sum2 = k + y; // local variable
            Console.WriteLine("The Value of Sum1 is:" + sum1);
            Console.WriteLine("The Value of Sum2 is:" + sum2);

        }
        public void I2()
        {
            Console.WriteLine("This is an Instance Method 2:");
            I1();//Calling instance method in instance method --> Directly
            S1();//Calling static method in instance method   --> Directly /Classname
        }

        public static void S1()
        {
            Console.WriteLine("This is Static Method 1:");
            InstanceandStaticConceptsOne p1 = new InstanceandStaticConceptsOne();
            int sum3 = p1.i + p1.j;//Calling Instance variable in static method  --> Object creation
            Console.WriteLine("The value of instance variables in static Method is:" + sum3);

            int sum4 = k + y; //Calling Static variable in static method --> Directly
            Console.WriteLine("The value of static variables in static Method is:" + sum4);


        }

        public static void S2()
        {
            Console.WriteLine("This is Static Method:");
            S1();//Calling static method in static method --> Directly /Classname
        }


    }
}

    

