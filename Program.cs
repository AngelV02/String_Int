using System;
using System.Collections.Generic;

namespace DivideByNumberApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create a list of integers
                List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

                // Ask the user for a number to divide each number in the list by
                Console.WriteLine("Enter a number to divide each number in the list by:");
                string userInput = Console.ReadLine();
                int divisor = Convert.ToInt32(userInput);

                // Write a loop that divides each integer in the list by the user-entered number and displays the result
                foreach (int number in numbers)
                {
                    int result = number / divisor;
                    Console.WriteLine($"{number} divided by {divisor} is {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                // Handle DivideByZeroException
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                // Handle FormatException
                Console.WriteLine("Error: Invalid input. Please enter a valid number.");
            }
            finally
            {
                // This block will always run, regardless of whether an exception occurred or not
                Console.WriteLine("Program has emerged from the try/catch block and continued with program execution.");
            }

            // Code execution continues here after the try/catch block

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
