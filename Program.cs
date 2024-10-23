// See https://aka.ms/new-console-template for more information
/* -------- Objectives To Follow ----------
 * Let it generate numbers from 1 to the stipulated number inputed by the user (set a limit to 200)
 * Let it run through and print out each number consecutively from 1 to the stipulated number
 * For each number that is divisible by 3, let it print out fizz instead of the number
 * For each number that is divisible by 5, let it print out buzz instead of the number
 * For each number that is divisible by both 3 & 5, let it print out FizzBuzz instead of the number
 * Else, let it print out the remaining numbers like that
 * And if a number inputed by the user isn't in the range of 200, let the compiler display an error and tell the user to select a number between one and 200
 * --------- End Of Objectives ------------- */
using System;


namespace Fizz
{
    public class FizzBuzz
    {
        static void Main (string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Hi. Welcome To FizzBuzz\n");

            int maxNumber;
            do
            {
                Console.WriteLine("Please select the highest number for the range (between 1 and 200): \n");
                string userInput = Console.ReadLine();

                if (int.TryParse(userInput, out maxNumber) && maxNumber >= 1 && maxNumber <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please kindly enter a number between 1 and 200.\n");
                }
            }
            while (true);

            for (int i = 1; i <= maxNumber; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if ( i % 3 == 0 )
                {
                    Console.WriteLine("Fizz");
                }
                else if ( i % 5 == 0 )
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
