using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{  
    public class DayOfWeekP
    {    
        public static void DayOfWeek()
        {   //variables
            int x, yx, mx, dx;

            Console.WriteLine("Please enter the date in Numbers :");
            Console.Write("Day (1 - 30/31) : ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month (1 - 12) : ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Year(only 4 digit) : ");
            int y = Convert.ToInt32(Console.ReadLine());

            //calculations
            yx = y - (14 - m) / 12;
            x = yx + yx / 4 - yx / 100 + yx / 400;
            mx = m + 12 * ((14 - m) / 12) - 2;
            dx = (d + x + 31 * mx / 12) % 7;

            //selection statement
            switch (dx)
            {
                case 0:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Sunday", d, m, y);
                    break;
                case 1:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Monday", d, m, y);
                    break;
                case 2:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Tuesday", d, m, y);
                    break;
                case 3:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Wednesday", d, m, y);
                    break;
                case 4:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Thursday", d, m, y);
                    break;
                case 5:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Friday", d, m, y);
                    break;
                case 6:
                    Console.WriteLine("\nDate : {0}/{1}/{2} - falls on Saturday", d, m, y);
                    break;
            }
        }
    }

}
