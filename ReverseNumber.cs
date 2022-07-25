using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    internal class ReverseNumber
    {
        public void getTheReverse()
        {   
            //variables
            int num, remainder, reverse = 0;

            Console.Write("Enter number to reverse : "); //taking input from user
            num = Convert.ToInt32(Console.ReadLine());

            //loop to generate the reverse number
            while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num /= 10;

            }
            Console.WriteLine("Number after Reverse : " + reverse);
        }
    }
}

