using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class ExecuteClassesOne
    {
        static void Main(string[] args)
        {
            Console.WriteLine("/////Underatnding concepts of Instance and static variables/Methos//////");
            //Instance Variables 
            InstanceandStaticConceptsOne e1 = new InstanceandStaticConceptsOne();
            e1.I1();
            e1.I2();

            //Static Methods
            InstanceandStaticConceptsOne.S1();
            InstanceandStaticConceptsOne.S2();
           
            Console.WriteLine("//////understading Concept of Constructor//////");
            ConstructorConceptTwo e2 = new ConstructorConceptTwo(40,20);
            e2.I1();

            ConstructorConceptTwo e22 = new ConstructorConceptTwo();

            ConstructorConceptTwo e222 = new ConstructorConceptTwo(46);
            e222.I2();

            ConstructorConceptTwo.s1(); 
            
            Console.WriteLine("///////understading Concept of ReturnTypeMethodConceptThree////");
            ReturnTypeMethodConceptThree e3 = new ReturnTypeMethodConceptThree();
            e3.m1(20,40);

            ReturnTypeMethodConceptThree.s1();          

            Console.WriteLine("/////understading Concept of Access modifiers");
            Accessmodifiersconceptfour e4 = new Accessmodifiersconceptfour();
            e4.I1(10, 40);

            Console.WriteLine("///////understading Concept of Access modifiers and Inheritance");
            AccessmodifiersandInheritnceConcept5 e5 = new AccessmodifiersandInheritnceConcept5();
            e5.I1(26,26);
            e5.I4();
           

            Console.WriteLine("//////understading Concept of Method overriding");
            InheritanceConceptMethodOverridding7 e6 = new InheritanceConceptMethodOverridding7();
            e6.I1();
            e6.I2();

            Console.WriteLine("\n");
            Console.WriteLine("//////understading Concept of Implicit and Explcit\"");
            ImplicitandExplicitConcept8 e7 = new ImplicitandExplicitConcept8();
            e7.Implicit();
            e7.explicitt();
            e7.conversion();

            Console.WriteLine("//////understading Concept of This Keyword\"");
            ThisConcept9 e8 = new ThisConcept9(10,40);
            e8.I1();

            Console.WriteLine("//////understading Concept of IfElse\"");
            IfElseConcept10 e9 = new IfElseConcept10(20);
            e9.validateage();
            e9.validateagetwo();



            Console.ReadLine();
        }

    }
}