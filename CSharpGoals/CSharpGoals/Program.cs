using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGoals
{
    class Program
    {
        static void Main()
        {
            int[] multiplesOfThree = {3, 6, 9, 12};
            string anExample = "An example of a multiple of three is ";
            var aMultipleOfThree = multiplesOfThree[2];
            string displayedExample = string.Format("{0} {1}", anExample, aMultipleOfThree);
            
            foreach (var number in multiplesOfThree)

            {
                Console.WriteLine(number.ToString());
            }
            

            Console.WriteLine(displayedExample, aMultipleOfThree);
            
            Console.ReadLine();
        }
    }
}
