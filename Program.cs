namespace D6LogicalProblems
{   
    public class Program
    {
        //An entrypoint of any console app
        static void Main(string[] args)
        {
            int option; //variable declaration

            Console.WriteLine("Welcome to the Logical Programs");

            //loop to exit when use enter select exit
            do { 
                Console.WriteLine("\nPlease select an option to procced :");
                Console.WriteLine("1.Print Fibonacci Series \n2.Perfect Number \n3.Prime Number \n4.Reverse Number \n5.Coupon Number \n6.Stop Watch \n7.Notes Vending machine \n8.Day Of Week\n9.Exit  ");
                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Fibonacci fibonacci = new Fibonacci();
                        fibonacci.PrintFibonacciSeries();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.CheckPerfectNum();
                        break;
                    case 3:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.CheckPrimeNum();
                        break;
                    case 4:
                        ReverseNumber reverseNumber = new ReverseNumber();
                        reverseNumber.getTheReverse();
                        break;
                    case 5:
                        CouponNumber couponNumber = new CouponNumber();
                        couponNumber.GetCouponNumber();
                        break;
                    case 6:
                        StopWatchSimulator stopWatch = new StopWatchSimulator();
                        stopWatch.StopWatchSimulatorP();
                        break;
                    case 7:
                        NotesVendingMachine.FindNotes(); //static method, calling using class name
                        break;
                    case 8:
                        DayOfWeekP.DayOfWeek();
                        break;


                }

            } while(option != 8);
        }
    }
}