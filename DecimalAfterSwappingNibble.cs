using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class DecimalAfterSwappingNibble
    {
        public static void DecimalAfterNibbleSwap()
        {
            int[] swapNibbles = new int[8];
            int[] powOf2 = { 128, 64, 32, 16, 8, 4, 2, 1 };
            int sum = 0;

            int[] binary = ToBinaryProgram.ToBinary(); //Calling Decimal to binary method to get the binary representation

            for (int i = 0; i < binary.Length; i++) //Loop to swap nibbles
            {
                if (i < 4)
                    swapNibbles[i + 4] = binary[i];
                else
                    swapNibbles[i - 4] = binary[i];
            }

            Console.WriteLine("\nAfter Swapping Nibbles, Binary Representation : ");
            for (int i = 0; i < 8; i++) //Loop to display swapNibbles array after swapping nibbles
            {
                Console.Write(swapNibbles[i] + " ");

            }

            for (int i = 0; i < 8; i++) //Loop to find the decimal number
            {
                if (swapNibbles[i] != 0)
                    sum = sum + powOf2[i];

            }

            Console.WriteLine();
            Console.WriteLine("Decimal Number after swapping nibble : " + sum);

        }
    }
}
