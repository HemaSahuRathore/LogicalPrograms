using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    internal class Fibonacci
    {
        public void PrintFibonacciSeries()
        {
            int n, num3;
            int num1 = 0, num2 = 1;

            Console.Write("Enter the number of elements to be printer in Fibonacci Series : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write(num1 + " " + num2 + " ");

            for (int i = 0; i < n; i++)
            {
                num3 = num1 + num2;
                Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;

            }

        }
    }
}
