using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    public class ThisConcept9
    {
        int savings;
        int expendatures;

        public ThisConcept9(int saving, int expendature)
        {
            this.savings = saving;
            this.expendatures = expendature; 
        }
        public void I1()
        {
            Console.WriteLine("My monthyly saving is :" + savings);
            Console.WriteLine("My monthyly Expenditure is :" + expendatures);
        }


    }
}
