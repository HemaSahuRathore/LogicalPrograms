using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D6LogicalProblems
{
    public class NotesVendingMachine
    {   
       public static void FindNotes()
        {   //Array for storing Notes domination
            int[] notes = { 1, 2, 5, 10, 50, 100, 500, 1000 };

            Console.WriteLine("\nEnter the amount : ");
            int amount = Convert.ToInt32(Console.ReadLine());
            int noOfNotes;

            for (int i = notes.Length - 1; i > 0; i--) 
            {
                while (amount >= notes[i])
                {
                    noOfNotes = amount / notes[i]; 
                    Console.WriteLine("\nTotal no. of {0} is {1}", notes[i], noOfNotes);
                    amount = amount - (noOfNotes * notes[i]);

                }
            }
        }

    }
}

