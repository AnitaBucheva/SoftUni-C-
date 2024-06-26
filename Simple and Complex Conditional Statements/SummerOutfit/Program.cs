using System;

namespace ClothingRecommendation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read the temperature from the console
           
            int temperature = ReadTemperature();

            // Read the time of day from the console
          
            string timeOfDay = Console.ReadLine();

            // Determine the clothing and shoes based on the temperature and time of day
            string clothing;
            string shoes;

            switch (timeOfDay)
            {
                case "Morning":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        clothing = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (temperature >= 19 && temperature <= 24)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (temperature >= 10 && temperature <= 18)
                    {
                        clothing = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature >= 19 && temperature <= 24)
                    {
                        clothing = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        clothing = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    clothing = "Shirt";
                    shoes = "Moccasins";
                    break;
                default:
                    Console.WriteLine("Invalid time of day.");
                    return;
            }

            // Print the recommendation
            Console.WriteLine($"It's {temperature} degrees, get your {clothing} and {shoes}.");
        }

        static int ReadTemperature()
        {
            int temperature;
            while (!int.TryParse(Console.ReadLine(), out temperature) || temperature < 10 || temperature > 42)
            {
                Console.WriteLine("Invalid input. Please enter a temperature between 10 and 42.");
            }
            return temperature;
        }
    }
}
