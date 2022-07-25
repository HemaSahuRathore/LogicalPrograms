using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class TempConversion
    {
        public static void TempConversionP()
        {
            int F, C;
            Console.WriteLine("Enter the option from below :");
            Console.Write("\n1.Celsius to Fahrenheit \n2.Fahrenheit to Celsius :  ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Write("Enter Temperature in Celsius : ");
                C = Convert.ToInt32(Console.ReadLine());
                F = (C * 9 / 5) + 32;
                Console.WriteLine("Temperature in Fahrenheit : " + F);
            }
            else if (option == 2)
            {
                Console.Write("Enter Temperature in Fahrenheit : ");
                F = Convert.ToInt32(Console.ReadLine());
                C = (F - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius : " + C);
            }
            else
                Console.WriteLine("Invalid Input!!!!");
        }
    }
}