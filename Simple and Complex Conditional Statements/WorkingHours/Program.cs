using System;

namespace OfficeHoursChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the hour of the day
          
            int hour = ReadHour();

            // Read the day of the week
           
            string dayOfWeek = Console.ReadLine();

            // Determine if the office is open
            string status = IsOfficeOpen(hour, dayOfWeek) ? "open" : "closed";

            // Print the result
            Console.WriteLine($"{status}");
        }

        static int ReadHour()
        {
            int hour;
            while (!int.TryParse(Console.ReadLine(), out hour) || hour < 0 || hour > 23)
            {
                Console.WriteLine("Invalid input. Please enter a valid hour (0-23).");
            }
            return hour;
        }

        static bool IsOfficeOpen(int hour, string dayOfWeek)
        {
            // Check if the day is Monday through Saturday
            bool isWorkingDay = dayOfWeek switch
            {
                "Monday" => true,
                "Tuesday" => true,
                "Wednesday" => true,
                "Thursday" => true,
                "Friday" => true,
                "Saturday" => true,
                _ => false
            };

            // Check if the hour is within working hours
            bool isWorkingHour = hour >= 10 && hour < 18;

            // The office is open if it's a working day and within working hours
            return isWorkingDay && isWorkingHour;
        }
    }
}
