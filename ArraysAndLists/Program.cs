using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            int[] numbers = new int[] { 1, 2, 3,4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> Odds = new List<int>();
            List<int> Evens = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            for (int a = 0; a < numbers.Length; a++)
            {
                if (numbers[a] % 2 == 0)
                    Odds.Add(numbers[a]);
                else
                    Evens.Add(numbers[a]);
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            foreach (int a in Odds)
            {
                Console.WriteLine($" This number is a odd number {a}");
            }
            foreach (int a in Evens)
            {
                Console.WriteLine($" These are even numbers {a}");
            }
               
               
        }  

        
        



    }
}
