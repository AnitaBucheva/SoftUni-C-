using System;

namespace AthletesTimeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the times of the three athletes
            
            int time1 = ReadTimeInSeconds();

            int time2 = ReadTimeInSeconds();

            int time3 = ReadTimeInSeconds();

            // Calculate the total time in seconds
            int totalTimeInSeconds = time1 + time2 + time3;

            // Convert total time to minutes and seconds
            int minutes = totalTimeInSeconds / 60;
            int seconds = totalTimeInSeconds % 60;

            // Print the result in "minutes:seconds" format with leading zero for seconds if necessary
            Console.WriteLine($"{minutes}:{seconds:D2}");
        }

        static int ReadTimeInSeconds()
        {
            int time;
            while (!int.TryParse(Console.ReadLine(), out time) || time < 1 || time > 50)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in seconds (between 1 and 50).");
            }
            return time;
        }
    }
}
