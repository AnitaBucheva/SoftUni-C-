using System;

namespace SumOfDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter a positive integer number
           
            int number = int.Parse(Console.ReadLine());

            // Calculate the sum of digits
            int sum = 0;
            int tempNumber = number; // Temporary variable to store the number

            while (tempNumber > 0)
            {
                // Get the last digit of the number
                int digit = tempNumber % 10;

                // Add the digit to the sum
                sum += digit;

                // Remove the last digit from the number
                tempNumber /= 10;
            }

            // Print the sum of digits
            Console.WriteLine($"{sum}");
        }
    }
}
