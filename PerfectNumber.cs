using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    internal class PerfectNumber
    {

        int sum = 0; //variable

        public void CheckPerfectNum()
        {
            Console.Write("Enter Number to check Perfect Number : ");
            int num = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < num; i++) //loop to search for the divisors
            {
                if (num % i == 0)
                {
                    sum += i; //Adding the divisor to previous sum

                }
            }

            Console.WriteLine("Sum of divisors is " + sum);

            //Selection statement
            if (sum == num) //Checking if both value equals
                Console.WriteLine("It is Perfect number");
            else
                Console.WriteLine("It is not a Perfect number");

        }
    }
}

