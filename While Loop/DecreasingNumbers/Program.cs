using System;

namespace Countdown
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer N
           
            int N = int.Parse(Console.ReadLine());

            // Ensure N is greater than 1
            if (N <= 1)
            {
             
                return;
            }

            // Loop from N down to 1
            while (N >= 1)
            {
                // Print the current value of N
                Console.WriteLine(N);

                // Decrement the counter variable
                N--;
            }
        }
    }
}
