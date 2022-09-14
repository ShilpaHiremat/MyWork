using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewProject_One.ProgrammingConcepts
{
    // Type casting
    // Implicit type casting : Converting smaller type to larger type (automatically)
    // Explicit type casting : Converting larger type to smaller type (Manually)
    public class ImplicitandExplicitConcept8
    {
        public void Implicit()
        {
            // char -> int -> long -> float -> double
            int i = 10;
            double j = 6;
            j = i;
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
       public void explicitt()
        {
            int i = 10;
            double j = 20.66;
            i =(int)j;

            Console.WriteLine(i);
            Console.WriteLine(j);
        }
        //Type Conversion methods
        // Convert.ToBoolean;
        // Convert.ToDouble;
        // Convert.ToString;
        // Convert.ToInt32(int);
        // Convert.ToInt64(long)
        int i = 10;
        string str = "ravi";
        char h = 'F';
        float f = 79;
        double d = 78.44;

        public void conversion()
        {
            //Convert int to string
            string name = Convert.ToString(i);
            Console.WriteLine(name);
            Console.WriteLine( i.GetType());
            Console.WriteLine( name.GetType());

            string a = "HouseNo";
            int b = 110;
            string c = a + Convert.ToString(b);
            Console.WriteLine(c);

            Console.WriteLine( f.GetType());

            double d = 1500.75;
            int e = (int)d;
            Console.WriteLine(e);

           

            
            

        }
    }
}
