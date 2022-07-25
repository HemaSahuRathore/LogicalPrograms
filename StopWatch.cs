using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; //added

namespace D6LogicalProblems
{
    public class StopWatchSimulator
    {
        public void StopWatchSimulatorP()
        {
            Stopwatch stopWatch = new Stopwatch(); //creating object of pre-defined Stopwatch Class
            Console.WriteLine("Press '1' to Start the Stopwatch : ");
            int start = Convert.ToInt32(Console.ReadLine());
            stopWatch.Start(); //using Start method of StopWatch Class
            
            //Executing Fibonnacci program to cal. elapsed time
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

            Console.WriteLine("\nEnter '0' to stop stopwatch");
            int stop = Convert.ToInt32(Console.ReadLine());
            stopWatch.Stop(); //using Start method of StopWatch Class

            Console.WriteLine("Time taken to run the program(elaspsed time) : " + stopWatch.ElapsedMilliseconds);

        }
    }
}
