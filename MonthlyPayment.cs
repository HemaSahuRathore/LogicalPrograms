using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class MonthlyPayment
    {
        public static void MonthlyPay()
        {   //variables
            int P, Y, n;
            double r, x, R, payment;

            //taking user input
            Console.Write("Enter the Principal Amount : ");
            P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Rate of Interest : ");
            R = Convert.ToDouble(Console.ReadLine());
            Console.Write("No.of years to pay off : ");
            Y = Convert.ToInt32(Console.ReadLine());

            //calculation
            r = R / 1200;
            n = 12 * Y;
            x = 1 / Math.Pow(1 + r, n);

            payment = (P * r) / (1 - x);

            //display result
            Console.WriteLine("Your Monthyly payment is : " + payment);

        }
    }
}
