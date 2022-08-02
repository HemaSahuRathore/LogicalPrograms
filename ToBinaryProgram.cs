using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class ToBinaryProgram
    {
        public static void ToBinary()
        {   
            //Variables
            int decimalNum;
            int sum = 0;

            Console.Write("Please enter Decimal number : ");
            decimalNum = Convert.ToInt32(Console.ReadLine());

            int[] powOf2 = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int[] binary = new int[8];


            for (int i = 0; i < 8; i++)
            {
                if (decimalNum >= powOf2[i])
                {
                    decimalNum = decimalNum - powOf2[i];
                    binary[i] = 1;
                }
                else
                {
                    binary[i] = 0;
                    decimalNum = decimalNum;

                }

            }

            Console.WriteLine("Binary Representation is : ");
            //Loop to display Binary array
            for (int i = 0; i < 8; i++)
            {
                Console.Write(binary[i] + " ");
            }
       
        }
    }
}
