using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class PrimeNumber
    {
        public void CheckPrimeNum()
        {
            int flag = 0;
            Console.Write("Enter number to check for Prime Number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 1) //1 is not a prime number
                Console.WriteLine("It is not a Prime Number");
            else if (num == 2) //Only even prime number
                Console.WriteLine("It is a Prime Number");
            else
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = 1;
                        break;
                    }
                }

            if (flag == 0)
               Console.WriteLine("It is a Prime number");
            else
               Console.WriteLine("It is not a Prime number");

            }

        }
    }
}
