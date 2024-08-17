using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the maximum number
           
            int n = int.Parse(Console.ReadLine());

            // Print the first number in the sequence
   
            // Initialize the current number with the first number (1)
            int currentNumber = 1;

            // Print the sequence until the current number exceeds n
            while (currentNumber <= n)
            {
                Console.WriteLine(currentNumber);

                // Calculate the next number in the sequence
                currentNumber = 2 * currentNumber + 1;
            }
        }
    }
}
