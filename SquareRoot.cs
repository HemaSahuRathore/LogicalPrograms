using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class Sqrt
    {
        public static void SquareRoot()
        {   //variables
            double c, t, epsilon;

            Console.Write("Please enter non negative number to find Square Root: ");
            c = Convert.ToDouble(Console.ReadLine());

            //calculations
            t = c;
            epsilon = 1e-15;

            while (Math.Abs(t - (c / t)) > (epsilon * t))
            {
                t = (c / t + t) / 2.0;
            }

            //display result
            Console.WriteLine("Square root of {0} is {1}", c, t);

        }
    }
}

