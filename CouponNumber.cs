using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class CouponNumber
    {
        public void GetCouponNumber()
        {
            int i, count = 0;
            int randNum;

            Console.Write("Enter no. of coupons you need: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] coupArray = new int[num];

            Random random = new Random();

            for (i = 0; i < coupArray.Length; i++) //loop to add distinct elements in array
            {
                randNum = random.Next(10, 80);
                count++;
                while (IsCouponExist(randNum, coupArray)) //if element exist
                {
                    randNum = random.Next(10, 80); //generate random number again
                    count++;
                }

                coupArray[i] = randNum;
            }

            for (i = 0; i < coupArray.Length; i++) //To display coupon numbers
            {
                Console.WriteLine(coupArray[i]);

            }

            //display the number of Random numbers generated to get distinct coupon number
            Console.WriteLine("Total number of Random Generated to generate distinct coupon is : " + count);
        }

        //Method to check whether the random number generated is already exist in array
        public bool IsCouponExist(int randNum, int[] coupArray)
        {
            for (int j = 0; j < coupArray.Length; j++)
            {
                if (coupArray[j] == randNum)
                {
                    return true;
                }

            }
            return false;
        }

    }
}