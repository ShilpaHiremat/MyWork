using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class IfElseConcept10
    {
        int age; 

        public IfElseConcept10(int age)
        {
            this.age = age; 
        }

        public void validateage()
        {
            if (age > 18)
                Console.WriteLine("eligibale for Vote");
            else
                Console.WriteLine("Not eligibale for vote");

        }

        public void validateagetwo()
        {
            if (age >18)
            {
                Console.WriteLine("He/She is eligible to vote");
            }
            else if(age <18)
            {
                Console.WriteLine("He/She is not eligible to vote");
            }
            else
            {
                Console.WriteLine("This man doesn't exist");
            }
        }

    }
}
