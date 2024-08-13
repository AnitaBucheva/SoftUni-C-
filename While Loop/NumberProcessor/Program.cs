using System;

namespace CommandProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the initial number from the input
          
            int number = int.Parse(Console.ReadLine());

            // Process commands until "End" command is received
            while (true)
            {
                // Read the next command
               
                string command = Console.ReadLine();

                // Process the command
                switch (command)
                {
                    case "Inc":
                        number++; // Increment the number
                        break;
                    case "Dec":
                        number--; // Decrement the number
                        break;
                    case "End":
                        // Print the final number and stop the program
                        Console.WriteLine($"{number}");
                        return;
                    
                }
            }
        }
    }
}
